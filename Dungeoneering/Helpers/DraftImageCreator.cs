using System;
using System.Web.Mvc;
using Merwer.Chronicle.Dungeoneering.Tracker.Models;
using System.Drawing;
using System.Linq;
using System.Drawing.Text;
using System.IO;
using System.Collections.Generic;

namespace Merwer.Chronicle.Dungeoneering.Tracker.Helpers
{
    internal class DraftImageCreator
    {
        public DraftImageCreator()
        {
        }

        const int IMAGE_LINE_WIDTH = 250;
        const int IMAGE_SEPARATOR_BETWEEN_SECTIONS = 20;
        const int IMAGE_WIDTH = IMAGE_LINE_WIDTH * 2 + IMAGE_SEPARATOR_BETWEEN_SECTIONS;
        const int IMAGE_SECTION_HEADER_HEIGHT = 20;
        const int IMAGE_SECTION_BUFFER = 5;
        const int IMAGE_LINE_HEIGHT = 26;
        const int IMAGE_HEADER_OFFSET = 10;
        const int IMAGE_HEADER_HEIGHT = IMAGE_LINE_HEIGHT * 3 + IMAGE_HEADER_OFFSET;
        const int IMAGE_COUNT_OFFSET = 35;
        const int IMAGE_TEXT_VERTICAL_OFFSET = 2;
        private static readonly Font itemFont = new Font("Arial", 18, FontStyle.Regular, GraphicsUnit.Pixel);
        private static readonly Font headerFont = new Font("Arial", 18, FontStyle.Bold, GraphicsUnit.Pixel);

        public byte[] CreateDraftImage(Draft draft, IEnumerable<KeyValuePair<Card, int>> cards)
        {
            var supports = cards.Where(c => c.Key.Type == CardType.Support).OrderBy(c => c.Key.Cost);
            var creatures = cards.Where(c => c.Key.Type == CardType.Combat).OrderBy(c => c.Key.Health);
            var maxCount = Math.Max(supports.Count(), creatures.Count());
            using (Bitmap image = new Bitmap(IMAGE_WIDTH, (maxCount * IMAGE_LINE_HEIGHT) + IMAGE_HEADER_HEIGHT + IMAGE_SECTION_HEADER_HEIGHT + IMAGE_SECTION_BUFFER))
            {
                using (Graphics g = Graphics.FromImage(image))
                {
                    g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
                    g.Clear(Color.White);
                    CreateSummary(g, draft, 0, 0);
                    CreateSupports(g, supports, 0, IMAGE_HEADER_HEIGHT);
                    CreateCombats(g, creatures, IMAGE_LINE_WIDTH + IMAGE_SEPARATOR_BETWEEN_SECTIONS, IMAGE_HEADER_HEIGHT);
                }

                MemoryStream ms = new MemoryStream();

                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                return ms.ToArray();
            }
        }

        private void CreateSummary(Graphics g, Draft d, int x, int y)
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
            g.DrawString("chroniclecompass.com/Drafts/" + d.Id, itemFont, drawBrush, new PointF(x, y));
            g.DrawString(text1, itemFont, drawBrush, new PointF(x, y + IMAGE_LINE_HEIGHT));
            g.DrawString(text2, headerFont, drawBrush, new PointF(x, y + (IMAGE_LINE_HEIGHT * 2)));
        }

        private void CreateSupports(Graphics g, IOrderedEnumerable<KeyValuePair<Card, int>> supports, int x, int y)
        {
            int count = supports.Sum(kvp => kvp.Value);
            string text = "     Support";
            DrawSupport(g, headerFont, text, count, x, y);
            int currY = y + IMAGE_SECTION_BUFFER;
            foreach (KeyValuePair<Card, int> entry in supports)
            {
                currY += IMAGE_LINE_HEIGHT;
                DrawSupport(g, itemFont, entry.Key.Name, entry.Value, x, currY);
                DrawBorder(g, x, currY);
            }
        }

        private void DrawSupport(Graphics g, Font font, string text, int count, int x, int y)
        {
            Brush pen = new SolidBrush(Color.Blue);
            g.FillRectangle(pen, x, y, IMAGE_LINE_WIDTH, IMAGE_LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(x, y + IMAGE_TEXT_VERTICAL_OFFSET));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(x + IMAGE_LINE_WIDTH - IMAGE_COUNT_OFFSET, y + IMAGE_TEXT_VERTICAL_OFFSET));
        }

        private void DrawBorder(Graphics g, int x, int y)
        {
            Pen pen = new Pen(Color.Gold);
            g.DrawRectangle(pen, x, y, IMAGE_LINE_WIDTH, IMAGE_LINE_HEIGHT);
        }

        private void CreateCombats(Graphics g, IOrderedEnumerable<KeyValuePair<Card, int>> combats, int x, int y)
        {
            int count = combats.Sum(kvp => kvp.Value);
            string text = "      Creatures";
            DrawCombat(g, headerFont, text, count, x, y);
            int currY = y + IMAGE_SECTION_BUFFER;
            foreach (KeyValuePair<Card, int> entry in combats)
            {
                currY += IMAGE_LINE_HEIGHT;
                DrawCombat(g, itemFont, entry.Key.Name, entry.Value, x, currY);
                DrawBorder(g, x, currY);
            }
        }

        private void DrawCombat(Graphics g, Font font, string text, int count, int x, int y)
        {
            Brush pen = new SolidBrush(Color.Red);
            g.FillRectangle(pen, x, y, IMAGE_LINE_WIDTH, IMAGE_LINE_HEIGHT);

            SolidBrush drawBrush = new SolidBrush(Color.White);
            g.DrawString(text, font, drawBrush, new PointF(x, y + IMAGE_TEXT_VERTICAL_OFFSET));
            g.DrawString("x" + count.ToString(), font, drawBrush, new PointF(x + IMAGE_LINE_WIDTH - IMAGE_COUNT_OFFSET, y + IMAGE_TEXT_VERTICAL_OFFSET));
        }
    }
}