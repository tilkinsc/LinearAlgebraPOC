using System.Diagnostics;
using Matrices;
using Vectors;

static void Vector4TestNormalize()
{
	Vector4 v1 = Vector4.From(8, 6, 7, 9);
	
	Vector4 v2 = Vector4.Normalize(v1);
	
	Console.WriteLine(v2.ToString());
	
}

static void Matrix22TestAdd()
{
	Matrix22 m1 = Matrix22.Zero();
	m1.m00 = 0.0f;
	m1.m01 = 2.0f;
	m1.m10 = 5.0f;
	m1.m11 = -1.0f;
	
	Matrix22 m2 = Matrix22.Zero();
	m2.m00 = -3.0f;
	m2.m01 = 0.0f;
	m2.m10 = 1.0f;
	m2.m11 = 4.0f;
	
	Matrix22 m3 = Matrix22.Add(m1, m2);
	
	// Console.WriteLine(m3.ToString());
	Debug.Assert(m3.m00 == -3.0f && m3.m01 == 2.0f && m3.m10 == 6.0f && m3.m11 == 3.0f, "Matrix22.Add failed.");
}

static void Matrix22TestSub()
{
	Matrix22 m1 = Matrix22.Zero();
	m1.m00 = 0.0f;
	m1.m01 = 2.0f;
	m1.m10 = 5.0f;
	m1.m11 = -1.0f;
	
	Matrix22 m2 = Matrix22.Zero();
	m2.m00 = -3.0f;
	m2.m01 = 0.0f;
	m2.m10 = 1.0f;
	m2.m11 = 4.0f;
	
	Matrix22 m3 = Matrix22.Sub(m1, m2);
	Matrix22 m4 = Matrix22.Sub(m2, m1);
	
	// Console.WriteLine(m3.ToString());
	// Console.WriteLine(m4.ToString());
	Debug.Assert(m3.m00 == 3.0f && m3.m01 == 2.0f && m3.m10 == 4.0f && m3.m11 == -5.0f, "Matrix22.Sub failed.");
	Debug.Assert(m4.m00 == -3.0f && m4.m01 == -2.0f && m4.m10 == -4.0f && m4.m11 == 5.0f, "Matrix22.Sub failed.");
}

static void Matrix22TestMulScalar()
{
	Matrix22 m1 = Matrix22.Zero();
	m1.m00 = 0.0f;
	m1.m01 = 2.0f;
	m1.m10 = 5.0f;
	m1.m11 = -1.0f;
	
	Matrix22 m2 = Matrix22.MulScalar(m1, 4.0f);
	
	// Console.WriteLine(m2.ToString());
	Debug.Assert(m2.m00 == 0.0f && m2.m01 == 8.0f && m2.m10 == 20.0f && m2.m11 == -4.0f, "Matrix22.MulScalar failed.");
}

static void Matrix22TestDeterminant()
{
	Matrix22 m1 = Matrix22.Zero();
	m1.m00 = 0.0f;
	m1.m01 = 2.0f;
	m1.m10 = 5.0f;
	m1.m11 = -1.0f;
	
	float determinant = Matrix22.Determinant(m1);
	
	// Console.WriteLine(determinant);
	Debug.Assert(determinant == -10.0f, "Matrix22.Determinant failed.");
}

static void Matrix22TestTransformation()
{
	Matrix22 m1 = Matrix22.Zero();
	m1.m00 = 2.0f;
	m1.m01 = 3.0f;
	m1.m10 = 1.0f;
	m1.m11 = -1.0f;
	
	Matrix22 m2 = Matrix22.Zero();
	m2.m00 = -3.0f;
	m2.m01 = 1.0f;
	m2.m10 = -2.0f;
	m2.m11 = 4.0f;
	
	Matrix22 m3 = Matrix22.Transform(m1, m2);
	
	// Console.WriteLine(m3.ToString());
	Debug.Assert(m3.m00 == -3.0f && m3.m01 == 5.0f && m3.m10 == 9.0f && m3.m11 == -4.0f, "Matrix22.Transform failed.");
}

Vector4TestNormalize();
Matrix22TestAdd();
Matrix22TestSub();
Matrix22TestMulScalar();
Matrix22TestDeterminant();
Matrix22TestTransformation();


