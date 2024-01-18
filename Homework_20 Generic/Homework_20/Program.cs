using Homework_20;

var pair1 = new ComparablePair<string,int>("2", 3);
var pair2 = new ComparablePair<string,int>("2", 2);

var comparer = new CompareReporter();

comparer.Report(pair1, pair2);
