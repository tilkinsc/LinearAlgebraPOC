namespace Vectors;

public sealed class Vector2 : IEquatable<Vector2>
{
	
	public float v0 = 0.0f;
	public float v1 = 0.0f;
	
	// Initializes as a Zero vector
	private Vector2()
	{
	}
	
	// Creates a new Vector with components 0 and 0
	// Since each component is public (read/write), theres no point to have a static readonly object
	public static Vector2 Zero()
	{
		return new Vector2();
	}
	
	// Creates a new Vector with components x and y
	public static Vector2 From(float x, float y)
	{
		Vector2 vector = new Vector2();
		vector.v0 = x;
		vector.v1 = y;
		return vector;
	}
	
		// Adds each component by its respective parameter
	public static Vector2 Add(Vector2 a, float x)
	{
		return From(a.v0 + x, a.v1);
	}
	
	// Adds each component by its respective parameter
	public static Vector2 Add(Vector2 a, float x, float y)
	{
		return From(a.v0 + x, a.v1 + y);
	}
	
	// Adds the respective components of a vector in the order of a + b
	public static Vector2 Add(Vector2 a, Vector2 b)
	{
		return From(a.v0 + b.v0, a.v1 + b.v1);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector2 Sub(Vector2 a, float x)
	{
		return From(a.v0 - x, a.v1);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector2 Sub(Vector2 a, float x, float y)
	{
		return From(a.v0 - x, a.v1 - y);
	}
	
	// Subtracts the respective components of a vector in the order of a - b
	public static Vector2 Sub(Vector2 a, Vector2 b)
	{
		return From(a.v0 - b.v0, a.v1 - b.v1);
	}
	
	// Multiplies each component by a singular scalar value
	public static Vector2 MulScalar(Vector2 a, float scalar)
	{
		return From(a.v0 * scalar, a.v1 * scalar);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector2 Mul(Vector2 a, float x)
	{
		return From(a.v0 * x, a.v1);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector2 Mul(Vector2 a, float x, float y)
	{
		return From(a.v0 * x, a.v1 * y);
	}
	
	// Multiplies the respective components of a vector in the order of a * b
	public static Vector2 Mul(Vector2 a, Vector2 b)
	{
		return From(a.v0 * b.v0, a.v1 * b.v1);
	}
	
	// Ensures that the value for a vector is between min and max
	public static Vector2 Clamp(Vector2 a, float min, float max)
	{
		Vector2 vector = new Vector2();
		vector.v0 = Math.Clamp(a.v0, min, max);
		vector.v1 = Math.Clamp(a.v1, min, max);
		return vector;
	}
	
	// Calculate the similarity/alignment from two vectors as a scalar value
	public static float Dot(Vector2 a, Vector2 b)
	{
		return (a.v0 * b.v0) + (a.v1 * b.v1);
	}
	
	// Calculate the length or distance of a vector from a Zero origin
	public static float Magnitude(Vector2 a)
	{
		return MathF.Sqrt((a.v0 * a.v0) + (a.v1 * a.v1));
	}
	
	// Divide each component by its magnitude to result in a normalized vector
	// If the magnitude is 0 or epsilon, a Zero vector is returned
	public static Vector2 Normalize(Vector2 a)
	{
		Vector2 vector = new Vector2();
		// Floats very close to at Epsilon may have undefined behavior
		float magnitude = 1.0f / Magnitude(a);
		if (magnitude > float.Epsilon)
		{
			// You can either divide each component by the magnitude
			// or you can precompute a scalar value to multiply to each component instead
			float inverseMagnitude = 1.0f / magnitude;
			vector.v0 = a.v0 * inverseMagnitude;
			vector.v1 = a.v1 * inverseMagnitude;
		}
		return vector;
	}
	
	// Calculates the difference between two vectors (b - a) and returns the distance (length) between them
	public static float Distance(Vector2 a, Vector2 b)
	{
		float dV0 = b.v0 - a.v0;
		float dV1 = b.v1 - a.v1;
		
		return MathF.Sqrt((dV0 * dV0) + (dV1 * dV1));
	}
	
	// Calculate the sum between two vectors (a + b) and returns the distance (length) between them
	public static float Length(Vector2 a, Vector2 b)
	{
		float dV0 = a.v0 + b.v0;
		float dV1 = a.v1 + b.v1;
		
		return MathF.Sqrt((dV0 * dV0) + (dV1 * dV1));
	}
	
	// Check if the members of one vector is equal to the members of another vector
	public bool Equals(Vector2? other)
	{
		if (other == null)
			return false;
		return
			   (v0 == other.v0)
			&& (v1 == other.v1);
	}
	
	// Pretty print
	public override string ToString()
	{
		return $"[{v0}, {v1}]";
	}
	
}