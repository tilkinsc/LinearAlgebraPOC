namespace Vectors;

public sealed class Vector3 : IEquatable<Vector3>
{
	
	public float v0 = 0.0f;
	public float v1 = 0.0f;
	public float v2 = 0.0f;
	
	// Initializes as a Zero vector
	private Vector3()
	{
	}
	
	// Creates a new Vector with components 0 0 and 0
	// Since each component is public (read/write), theres no point to have a static readonly object
	public static Vector3 Zero()
	{
		return new Vector3();
	}
	
	// Creates a new Vector with components x y and z
	public static Vector3 From(float x, float y, float z)
	{
		Vector3 vector = new Vector3();
		vector.v0 = x;
		vector.v1 = y;
		vector.v2 = z;
		return vector;
	}
	
	// Adds each component by its respective parameter
	public static Vector3 Add(Vector3 a, float x)
	{
		return From(a.v0 + x, a.v1, a.v2);
	}
	
	// Adds each component by its respective parameter
	public static Vector3 Add(Vector3 a, float x, float y)
	{
		return From(a.v0 + x, a.v1 + y, a.v2);
	}
	
	// Adds each component by its respective parameter
	public static Vector3 Add(Vector3 a, float x, float y, float z)
	{
		return From(a.v0 + x, a.v1 + y, a.v2 + z);
	}
	
	// Adds the respective components of a vector in the order of a + b
	public static Vector3 Add(Vector3 a, Vector3 b)
	{
		return From(a.v0 + b.v0, a.v1 + b.v1, a.v2 + b.v2);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector3 Sub(Vector3 a, float x)
	{
		return From(a.v0 - x, a.v1, a.v2);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector3 Sub(Vector3 a, float x, float y)
	{
		return From(a.v0 - x, a.v1 - y, a.v2);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector3 Sub(Vector3 a, float x, float y, float z)
	{
		return From(a.v0 - x, a.v1 - y, a.v2 - z);
	}
	
	// Subtracts the respective components of a vector in the order of a - b
	public static Vector3 Sub(Vector3 a, Vector3 b)
	{
		return From(a.v0 - b.v0, a.v1 - b.v1, a.v2 - b.v2);
	}
	
	// Multiplies each component by a singular scalar value
	public static Vector3 MulScalar(Vector3 a, float scalar)
	{
		return From(a.v0 * scalar, a.v1 * scalar, a.v2 * scalar);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector3 Mul(Vector3 a, float x)
	{
		return From(a.v0 * x, a.v1, a.v2);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector3 Mul(Vector3 a, float x, float y)
	{
		return From(a.v0 * x, a.v1 * y, a.v2);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector3 Mul(Vector3 a, float x, float y, float z)
	{
		return From(a.v0 * x, a.v1 * y, a.v2 * z);
	}
	
	// Multiplies the respective components of a vector in the order of a * b
	public static Vector3 Mul(Vector3 a, Vector3 b)
	{
		return From(a.v0 * b.v0, a.v1 * b.v1, a.v2 * b.v2);
	}
	
	// Ensures that the value for a vector is between min and max
	public static Vector3 Clamp(Vector3 a, float min, float max)
	{
		Vector3 vector = new Vector3();
		vector.v0 = Math.Clamp(a.v0, min, max);
		vector.v1 = Math.Clamp(a.v1, min, max);
		vector.v2 = Math.Clamp(a.v2, min, max);
		return vector;
	}
	
	// Calculate the similarity/alignment from two vectors as a scalar value
	public static float Dot(Vector3 a, Vector3 b)
	{
		return (a.v0 * b.v0) + (a.v1 * b.v1) + (a.v2 * b.v2);
	}
	
	// Calculate a vector that is perpendicular to two vectors
	public static Vector3 Cross(Vector3 a, Vector3 b)
	{
		Vector3 vector = new Vector3();
		vector.v0 = (a.v1 * b.v2) - (a.v2 * b.v1);
		vector.v1 = (a.v2 * b.v0) - (a.v0 * b.v2);
		vector.v2 = (a.v0 * b.v1) - (a.v1 * b.v0);
		return vector;
	}
	
	// Calculate the length or distance of a vector from a Zero origin
	public static float Magnitude(Vector3 a)
	{
		return MathF.Sqrt((a.v0 * a.v0) + (a.v1 * a.v1) + (a.v2 * a.v2));
	}
	
	// Divide each component by its magnitude to result in a normalized vector
	// If the magnitude is 0 or epsilon, a Zero vector is returned
	public static Vector3 Normalize(Vector3 a)
	{
		Vector3 vector = new Vector3();
		// Floats very close to at Epsilon may have undefined behavior
		float magnitude = Magnitude(a);
		if (magnitude > float.Epsilon)
		{
			// You can either divide each component by the magnitude
			// or you can precompute a scalar value to multiply to each component instead
			float inverseMagnitude = 1.0f / magnitude;
			vector.v0 = a.v0 * inverseMagnitude;
			vector.v1 = a.v1 * inverseMagnitude;
			vector.v2 = a.v2 * inverseMagnitude;
		}
		return vector;
	}
	
	// Calculates the difference between two vectors (b - a) and returns the distance between them
	public static float Distance(Vector3 a, Vector3 b)
	{
		float dV0 = b.v0 - a.v0;
		float dV1 = b.v1 - a.v1;
		float dV2 = b.v2 - a.v2;
		
		return MathF.Sqrt((dV0 * dV0) + (dV1 * dV1) + (dV2 * dV2));
	}
	
	// Check if the members of one vector is equal to the members of another vector
	public bool Equals(Vector3? other)
	{
		if (other == null)
			return false;
		return
			   (v0 == other.v0)
			&& (v1 == other.v1)
			&& (v2 == other.v2);
	}
	
	// Pretty print
	public override string ToString()
	{
		return $"[{v0}, {v1}, {v2}]";
	}
	
}