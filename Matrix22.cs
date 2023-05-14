namespace Matrices;

// row major
public sealed class Matrix22 : IEquatable<Matrix22>
{
	
	public float m00 = 0.0f;
	public float m01 = 0.0f;
	public float m10 = 0.0f;
	public float m11 = 0.0f;
	
	// Initializes as a Zero Matrix
	private Matrix22()
	{
	}
	
	// Initializes a matrix where all values are equal to 'value'
	private Matrix22(float value)
	{
		m00 = value;
		m01 = value;
		m10 = value;
		m11 = value;
	}
	
	// Create a new matrix where each component in a diagonal line are initialized to 1's
	// 1, 0,
	// 0, 1
	public static Matrix22 Identity()
	{
		Matrix22 matrix = new Matrix22();
		matrix.m00 = 1.0f;
		matrix.m11 = 1.0f;
		return matrix;
	}
	
	// Create a new matrix where all members are initialized to 0's
	// 0, 0,
	// 0, 0
	public static Matrix22 Zero()
	{
		return new Matrix22();
	}
	
	// Adding a matrix is defined as adding each lhand component to the rhand component
	// Irregardless of lhand or rhand, the values will be the same.
	public static Matrix22 Add(Matrix22 a, Matrix22 b)
	{
		Matrix22 c = new Matrix22();
		c.m00 = a.m00 + b.m00;
		c.m01 = a.m01 + b.m01;
		c.m10 = a.m10 + b.m10;
		c.m11 = a.m11 + b.m11;
		return c;
	}
	
	// Subtracting a matrix is defined as subtracting each lhand component to the rhand component
	// Depending on the lhand or rhand, the values may not be the same.
	public static Matrix22 Sub(Matrix22 a, Matrix22 b)
	{
		Matrix22 c = new Matrix22();
		c.m00 = a.m00 - b.m00;
		c.m01 = a.m01 - b.m01;
		c.m10 = a.m10 - b.m10;
		c.m11 = a.m11 - b.m11;
		return c;
	}
	
	// Multiplying by a scalar value is defined as multiplying each component by the scalar value
	public static Matrix22 MulScalar(Matrix22 a, float scalar)
	{
		Matrix22 c = new Matrix22();
		c.m00 = a.m00 * scalar;
		c.m01 = a.m01 * scalar;
		c.m10 = a.m10 * scalar;
		c.m11 = a.m11 * scalar;
		return c;
	}
	
	// Returns a scalar value which can provide information about the properties of a matrix such as Area
	public static float Determinant(Matrix22 a)
	{
		return (a.m00 * a.m11) - (a.m01 * a.m10);
	}
	
	// Combines two transformation matrices into a single transformation matrix
	// which is equal to transforming a vector by matrix b then by matrix a
	public static Matrix22 Transform(Matrix22 a, Matrix22 b)
	{
		Matrix22 c = new Matrix22();
		c.m00 = a.m00 * b.m00 + a.m01 * b.m10;
		c.m10 = a.m10 * b.m00 + a.m11 * b.m10;
		c.m01 = a.m00 * b.m01 + a.m01 * b.m11;
		c.m11 = a.m10 * b.m01 + a.m11 * b.m11;
		return c;
	}
	
	// Check if the members of one matrix is equal to the members of another matrix
	public bool Equals(Matrix22? other)
	{
		if (other == null)
			return false;
		return
			   (m00 == other.m00)
			&& (m01 == other.m01)
			&& (m10 == other.m10)
			&& (m11 == other.m11);
	}
	
	// Pretty print
	public override string ToString()
	{
		return $"[\n{m00}, {m01},\n{m10}, {m11}\n]";
	}
	
}