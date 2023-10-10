using Matrix;
using System;

Menu.MatrixImput(out Matrix.Matrix matrix);
var operations = new Operations(matrix);
operations.Print();

while (true)
{
    var index = Menu.SelectMatrixOperations(matrix);
    var operation = operations.SelectOperation(index);
    operation();
}


