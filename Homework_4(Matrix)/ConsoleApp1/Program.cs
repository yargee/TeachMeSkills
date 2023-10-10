using Matrix;

Menu.MatrixImput(out Matrix.Matrix matrix);
matrix.Print();
while (true)
{
    var operation = Menu.SelectMatrixOperations(matrix);
    operation();
}


