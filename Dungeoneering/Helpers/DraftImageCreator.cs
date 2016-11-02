using System;
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;
using System.IO;
using System.Collections.Generic;
using System.Drawing.Imaging;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Helpers
{
    internal class DraftImageCreator
    {
        private ImageFormat imageFormat;

        public DraftImageCreator() : this(ImageFormat.Png)
        { }

        private DraftImageCreator(ImageFormat imageFormat)
        {
            this.imageFormat = imageFormat;
        }

        public string GetImageFormatString()
        {
            // Hard coded type for now
            return "image/png";
        }

        // Line
        const int COUNT_OFFSET = 35;
        const int LINE_BUFFER = 0;
        const int LINE_HEIGHT = 26;
        const int TEXT_VERTICAL_MARGIN = 2;
        const int LINE_FONT_SIZE = 18;

        // Section
        const int SECTION_BUFFER = 20;
        const int SECTION_WIDTH = 250;
        const int SECTION_HEADER_BUFFER = 5;
        const int SECTION_HEADER_LINE_HEIGHT = 20;
        const int SECTION_HEADER_HEIGHT = SECTION_HEADER_LINE_HEIGHT + SECTION_HEADER_BUFFER;
        const int SECTION_HEADER_FONT_SIZE = LINE_FONT_SIZE;

        // Header
        const int HEADER_BUFFER = 10;
        const int HEADER_LINE_HEIGHT = LINE_HEIGHT;
        const int HEADER_HEIGHT = HEADER_LINE_HEIGHT * 3 + HEADER_BUFFER;
        const int HEADER_FONT_SIZE = LINE_FONT_SIZE;

        // Image
        const int IMAGE_WIDTH = SECTION_WIDTH * 2 + SECTION_BUFFER;

        private static readonly Font itemFont = new Font("Arial", LINE_FONT_SIZE, FontStyle.Regular, GraphicsUnit.Pixel);
        private static readonly Font headerFont = new Font("Arial", HEADER_FONT_SIZE, FontStyle.Bold, GraphicsUnit.Pixel);

        public byte[] CreateDraftImage(Draft draft, IEnumerable<KeyValuePair<Card, int>> cards)
        {
            var supports = cards.Where(c => c.Key.Type == CardType.Support).OrderBy(c => c.Key.Cost);
            var creatures = cards.Where(c => c.Key.Type == CardType.Combat).OrderBy(c => c.Key.Health);
            var maxCount = Math.Max(supports.Count(), creatures.Count());
            using (Bitmap image = new Bitmap(IMAGE_WIDTH, GetImageHeight(maxCount)))
            {
                using (Graphics g = Graphics.FromImage(image))
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    g.Clear(Color.White);
                    CreateSummary(g, draft, 0, 0);
                    CreateSupportSection(g, supports, 0, HEADER_HEIGHT);
                    CreateCombatSection(g, creatures, SECTION_WIDTH + SECTION_BUFFER, HEADER_HEIGHT);
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, imageFormat);
                    return ms.ToArray();
                }
            }
        }

        private int GetImageHeight(int cardCount)
        {
            return HEADER_HEIGHT +
                SECTION_HEADER_HEIGHT +
                cardCount * (LINE_HEIGHT + LINE_BUFFER);
        }

        private void CreateSummary(Graphics g, Draft d, int xOffset, int yOffset)
        {
            Brush drawBrush = new SolidBrush(Color.Black);
            string text1, text2;
            var wins = d.Matches.Count(m => m.Win);
            var losses = d.Matches.Count(m => !m.Win);
            if (d.Complete)
            {
                text1 = "Dungeon Run (" + d.Archetype + ")";
                text2 = wins + " Wins, " + losses + " Losses";
            }
            else
            {
                text1 = "Dungeon Draft (" + d.Archetype + ")";
                text2 = "Still Drafting";
            }
            g.DrawString("chroniclecompass.com/Drafts/" + d.Id, itemFont, drawBrush, new PointF(xOffset, yOffset));
            g.DrawString(text1, itemFont, drawBrush, new PointF(xOffset, yOffset + HEADER_LINE_HEIGHT));
            g.DrawString(text2, headerFont, drawBrush, new PointF(xOffset, yOffset + (HEADER_LINE_HEIGHT * 2)));
        }

        private void CreateSupportSection(Graphics g, IOrderedEnumerable<KeyValuePair<Card, int>> supports, int xOffset, int yOffset)
        {
            int count = supports.Sum(kvp => kvp.Value);
            string text = "     Support";
            DrawSupportLine(g, headerFont, text, count, xOffset, yOffset);
            int currY = yOffset + SECTION_HEADER_HEIGHT;
            foreach (KeyValuePair<Card, int> entry in supports)
            {
                DrawSupportLine(g, itemFont, entry.Key.Name, entry.Value, xOffset, currY);
                DrawBorder(g, xOffset, currY);
                currY += LINE_HEIGHT;
            }
        }

        private void DrawSupportLine(Graphics g, Font font, string text, int count, int xOffset, int yOffset)
        {
            Brush pen = new SolidBrush(Color.Blue);
            g.FillRectangle(pen, xOffset, yOffset, SECTION_WIDTH, LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(xOffset, yOffset + TEXT_VERTICAL_MARGIN));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(xOffset + SECTION_WIDTH - COUNT_OFFSET, yOffset + TEXT_VERTICAL_MARGIN));
        }

        private void DrawBorder(Graphics g, int x, int y)
        {
            Pen pen = new Pen(Color.Gold);
            g.DrawRectangle(pen, x, y, SECTION_WIDTH, LINE_HEIGHT);
        }

        private void CreateCombatSection(Graphics g, IOrderedEnumerable<KeyValuePair<Card, int>> combats, int xOffset, int yOffset)
        {
            int count = combats.Sum(kvp => kvp.Value);
            string text = "      Creatures";
            DrawCombatLine(g, headerFont, text, count, xOffset, yOffset);
            int currY = yOffset + SECTION_HEADER_HEIGHT;
            foreach (KeyValuePair<Card, int> entry in combats)
            {
                DrawCombatLine(g, itemFont, entry.Key.Name, entry.Value, xOffset, currY);
                DrawBorder(g, xOffset, currY);
                currY += LINE_HEIGHT;
            }
        }

        private void DrawCombatLine(Graphics g, Font font, string text, int count, int xOffset, int yOffset)
        {
            Brush pen = new SolidBrush(Color.Red);
            g.FillRectangle(pen, xOffset, yOffset, SECTION_WIDTH, LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(xOffset, yOffset + TEXT_VERTICAL_MARGIN));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(xOffset + SECTION_WIDTH - COUNT_OFFSET, yOffset + TEXT_VERTICAL_MARGIN));
        }
    }
}