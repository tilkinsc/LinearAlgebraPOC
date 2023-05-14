namespace Matrices;

// row major
public sealed class Matrix44 : IEquatable<Matrix44>
{
	
	public float m00 = 0.0f;
	public float m01 = 0.0f;
	public float m02 = 0.0f;
	public float m03 = 0.0f;
	public float m10 = 0.0f;
	public float m11 = 0.0f;
	public float m12 = 0.0f;
	public float m13 = 0.0f;
	public float m20 = 0.0f;
	public float m21 = 0.0f;
	public float m22 = 0.0f;
	public float m23 = 0.0f;
	public float m30 = 0.0f;
	public float m31 = 0.0f;
	public float m32 = 0.0f;
	public float m33 = 0.0f;
	
	// Initializes as a Zero Matrix
	private Matrix44()
	{
	}
	
	// Initializes a matrix where all values are equal to 'value'
	private Matrix44(float value)
	{
		m00 = value;
		m01 = value;
		m02 = value;
		m03 = value;
		m10 = value;
		m11 = value;
		m12 = value;
		m13 = value;
		m20 = value;
		m21 = value;
		m22 = value;
		m23 = value;
		m30 = value;
		m31 = value;
		m32 = value;
		m33 = value;
	}
	
	// Create a new matrix where each component in a diagonal line are initialized to 1's
	// 1, 0, 0, 0,
	// 0, 1, 0, 0,
	// 0, 0, 1, 0,
	// 0, 0, 0, 1
	public static Matrix44 Identity()
	{
		Matrix44 matrix = new Matrix44();
		matrix.m00 = 1.0f;
		matrix.m11 = 1.0f;
		matrix.m22 = 1.0f;
		matrix.m33 = 1.0f;
		return matrix;
	}
	
	// Create a new matrix where all members are initialized to 0's
	// 0, 0, 0, 0,
	// 0, 0, 0, 0,
	// 0, 0, 0, 0,
	// 0, 0, 0, 0
	public static Matrix44 Zero()
	{
		return new Matrix44();
	}
	
	// Adding a matrix is defined as adding each lhand component to the rhand component
	// Irregardless of lhand or rhand, the values will be the same.
	public static Matrix44 Add(Matrix44 a, Matrix44 b)
	{
		Matrix44 c = new Matrix44();
		c.m00 = a.m00 + b.m00;
		c.m01 = a.m01 + b.m01;
		c.m02 = a.m02 + b.m02;
		c.m03 = a.m03 + b.m03;
		c.m10 = a.m10 + b.m10;
		c.m11 = a.m11 + b.m11;
		c.m12 = a.m12 + b.m12;
		c.m13 = a.m13 + b.m13;
		c.m20 = a.m20 + b.m20;
		c.m21 = a.m21 + b.m21;
		c.m22 = a.m22 + b.m22;
		c.m23 = a.m23 + b.m23;
		c.m30 = a.m30 + b.m30;
		c.m31 = a.m31 + b.m31;
		c.m32 = a.m32 + b.m32;
		c.m33 = a.m33 + b.m33;
		return c;
	}
	
	// Subtracting a matrix is defined as subtracting each lhand component to the rhand component
	// Depending on the lhand or rhand, the values may not be the same.
	public static Matrix44 Sub(Matrix44 a, Matrix44 b)
	{
		Matrix44 c = new Matrix44();
		c.m00 = a.m00 - b.m00;
		c.m01 = a.m01 - b.m01;
		c.m02 = a.m02 - b.m02;
		c.m03 = a.m03 - b.m03;
		c.m10 = a.m10 - b.m10;
		c.m11 = a.m11 - b.m11;
		c.m12 = a.m12 - b.m12;
		c.m13 = a.m13 - b.m13;
		c.m20 = a.m20 - b.m20;
		c.m21 = a.m21 - b.m21;
		c.m22 = a.m22 - b.m22;
		c.m23 = a.m23 - b.m23;
		c.m30 = a.m30 - b.m30;
		c.m31 = a.m31 - b.m31;
		c.m32 = a.m32 - b.m32;
		c.m33 = a.m33 - b.m33;
		return c;
	}
	
	// Multiplying by a scalar value is defined as multiplying each component by the scalar value
	public static Matrix44 MulScalar(Matrix44 a, float scalar)
	{
		Matrix44 c = new Matrix44();
		c.m00 = a.m00 * scalar;
		c.m01 = a.m01 * scalar;
		c.m02 = a.m02 * scalar;
		c.m03 = a.m03 * scalar;
		c.m10 = a.m10 * scalar;
		c.m11 = a.m11 * scalar;
		c.m12 = a.m12 * scalar;
		c.m13 = a.m13 * scalar;
		c.m20 = a.m20 * scalar;
		c.m21 = a.m21 * scalar;
		c.m22 = a.m22 * scalar;
		c.m23 = a.m23 * scalar;
		c.m30 = a.m30 * scalar;
		c.m31 = a.m31 * scalar;
		c.m32 = a.m32 * scalar;
		c.m33 = a.m33 * scalar;
		return c;
	}
	
	// Check if the members of one matrix is equal to the members of another matrix
	public bool Equals(Matrix44? other)
	{
		if (other == null)
			return false;
		return
			   (m00 == other.m00)
			&& (m01 == other.m01)
			&& (m02 == other.m02)
			&& (m03 == other.m03)
			&& (m10 == other.m10)
			&& (m11 == other.m11)
			&& (m12 == other.m12)
			&& (m13 == other.m13)
			&& (m20 == other.m20)
			&& (m21 == other.m21)
			&& (m22 == other.m22)
			&& (m23 == other.m23)
			&& (m30 == other.m30)
			&& (m31 == other.m31)
			&& (m32 == other.m32)
			&& (m33 == other.m33);
	}
	
	// Pretty print
	public override string ToString()
	{
		return $"[\n{m00}, {m01}, {m02}, {m03},\n{m10}, {m11}, {m12}, {m13},\n{m20}, {m21}, {m22}, {m23},\n{m30}, {m31}, {m32}, {m33}\n]";
	}
	
}