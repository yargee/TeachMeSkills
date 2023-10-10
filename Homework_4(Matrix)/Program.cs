using Matrix;
using System;

Menu.MatrixImput(out Matrix.Matrix matrix);
var operations = new Operations(matrix);
operations.Print();

while (true)
{
    var index = Menu.SelectOperation();
    operations.StartOperation(index)();
}


