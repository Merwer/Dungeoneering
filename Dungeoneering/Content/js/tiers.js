function getCategoryForScore(score) {
    if (score <= 100 && score > 90) {
        return 0;
    }
    if (score <= 90 && score > 80) {
        return 1;
    }
    if (score <= 80 && score > 60) {
        return 2;
    }
    if (score <= 70 && score > 50) {
        return 3;
    }
    if (score <= 50 && score > 30) {
        return 4;
    }
    if (score <= 30 && score > 10) {
        return 5;
    }
    if (score <= 10 && score > 0) {
        return 6;
    }
    return 7;
}
