namespace Vectors;

public sealed class Vector4 : IEquatable<Vector4>
{
	
	public float v0 = 0.0f;
	public float v1 = 0.0f;
	public float v2 = 0.0f;
	public float v3 = 0.0f;
	
	// Initializes as a Zero vector
	private Vector4()
	{
	}
	
	// Creates a new Vector with components 0 0 0 and 0
	// Since each component is public (read/write), theres no point to have a static readonly object
	public static Vector4 Zero()
	{
		return new Vector4();
	}
	
	// Creates a new Vector with components x y z and w
	public static Vector4 From(float x, float y, float z, float w)
	{
		Vector4 vector = new Vector4();
		vector.v0 = x;
		vector.v1 = y;
		vector.v2 = z;
		vector.v3 = w;
		return vector;
	}
	
	// Adds each component by its respective parameter
	public static Vector4 Add(Vector4 a, float x)
	{
		return From(a.v0 + x, a.v1, a.v2, a.v3);
	}
	
	// Adds each component by its respective parameter
	public static Vector4 Add(Vector4 a, float x, float y)
	{
		return From(a.v0 + x, a.v1 + y, a.v2, a.v3);
	}
	
	// Adds each component by its respective parameter
	public static Vector4 Add(Vector4 a, float x, float y, float z)
	{
		return From(a.v0 + x, a.v1 + y, a.v2 + z, a.v3);
	}
	
	// Adds each component by its respective parameter
	public static Vector4 Add(Vector4 a, float x, float y, float z, float w)
	{
		return From(a.v0 + x, a.v1 + y, a.v2 + z, a.v3 + w);
	}
	
	// Adds the respective components of a vector in the order of a + b
	public static Vector4 Add(Vector4 a, Vector4 b)
	{
		return From(a.v0 + b.v0, a.v1 + b.v1, a.v2 + b.v2, a.v3 + b.v3);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector4 Sub(Vector4 a, float x)
	{
		return From(a.v0 - x, a.v1, a.v2, a.v3);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector4 Sub(Vector4 a, float x, float y)
	{
		return From(a.v0 - x, a.v1 - y, a.v2, a.v3);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector4 Sub(Vector4 a, float x, float y, float z)
	{
		return From(a.v0 - x, a.v1 - y, a.v2 - z, a.v3);
	}
	
	// Subtracts each component by its respective parameter
	public static Vector4 Sub(Vector4 a, float x, float y, float z, float w)
	{
		return From(a.v0 - x, a.v1 - y, a.v2 - z, a.v3 - w);
	}
	
	// Subtracts the respective components of a vector in the order of a - b
	public static Vector4 Sub(Vector4 a, Vector4 b)
	{
		return From(a.v0 - b.v0, a.v1 - b.v1, a.v2 - b.v2, a.v3 - b.v3);
	}
	
	// Multiplies each component by a singular scalar value
	public static Vector4 MulScalar(Vector4 a, float scalar)
	{
		return From(a.v0 * scalar, a.v1 * scalar, a.v2 * scalar, a.v3 * scalar);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector4 Mul(Vector4 a, float x)
	{
		return From(a.v0 * x, a.v1, a.v2, a.v3);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector4 Mul(Vector4 a, float x, float y)
	{
		return From(a.v0 * x, a.v1 * y, a.v2, a.v3);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector4 Mul(Vector4 a, float x, float y, float z)
	{
		return From(a.v0 * x, a.v1 * y, a.v2 * z, a.v3);
	}
	
	// Multiplies each component by its respective parameter
	public static Vector4 Mul(Vector4 a, float x, float y, float z, float w)
	{
		return From(a.v0 * x, a.v1 * y, a.v2 * z, a.v3 * w);
	}
	
	// Multiplies the respective components of a vector in the order of a * b
	public static Vector4 Mul(Vector4 a, Vector4 b)
	{
		return From(a.v0 * b.v0, a.v1 * b.v1, a.v2 * b.v2, a.v3 * b.v3);
	}
	
	// Ensures that the value for a vector is between min and max
	public static Vector4 Clamp(Vector4 a, float min, float max)
	{
		Vector4 vector = new Vector4();
		vector.v0 = Math.Clamp(a.v0, min, max);
		vector.v1 = Math.Clamp(a.v1, min, max);
		vector.v2 = Math.Clamp(a.v2, min, max);
		vector.v3 = Math.Clamp(a.v3, min, max);
		return vector;
	}
	
	// Calculate the similarity/alignment from two vectors as a scalar value
	public static float Dot(Vector4 a, Vector4 b)
	{
		return (a.v0 * b.v0) + (a.v1 * b.v1) + (a.v2 * b.v2) + (a.v3 * b.v3);
	}
	
	// Calculate a vector that is perpendicular to two vectors
	// Since the cross product is not defined for a 4d vector, the w component is set to 0
	public static Vector4 Cross(Vector4 a, Vector4 b)
	{
		Vector4 vector = new Vector4();
		vector.v0 = (a.v1 * b.v2) - (a.v2 * b.v1);
		vector.v1 = (a.v2 * b.v0) - (a.v0 * b.v2);
		vector.v2 = (a.v0 * b.v1) - (a.v1 * b.v0);
		vector.v3 = 0;
		return vector;
	}
	
	// Calculate the length or distance of a vector from a Zero origin
	public static float Magnitude(Vector4 a)
	{
		return MathF.Sqrt((a.v0 * a.v0) + (a.v1 * a.v1) + (a.v2 * a.v2) + (a.v3 * a.v3));
	}
	
	// Divide each component by its magnitude to result in a normalized vector
	// If the magnitude is 0 or episolon, a Zero vector is returned
	public static Vector4 Normalize(Vector4 a)
	{
		Vector4 vector = new Vector4();
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
			vector.v3 = a.v3 * inverseMagnitude;
		}
		return vector;
	}
	
	// Calculates the difference between two vectors (b - a) and returns the distance squared between them
	public static float DistanceSquared(Vector4 a, Vector4 b)
	{
		float dV0 = b.v0 - a.v0;
		float dV1 = b.v1 - a.v1;
		float dV2 = b.v2 - a.v2;
		float dV3 = b.v3 - a.v3;
		
		return (dV0 * dV0) + (dV1 * dV1) + (dV2 * dV2) + (dV3 * dV3);
	}
	
	// Calculates the difference between two vectors (b - a) and returns the distance between them
	public static float Distance(Vector4 a, Vector4 b)
	{
		return MathF.Sqrt(DistanceSquared(a, b));
	}
	
	// Check if the members of one vector is equal to the members of another vector
	public bool Equals(Vector4? other)
	{
		if (other == null)
			return false;
		return
			   (v0 == other.v0)
			&& (v1 == other.v1)
			&& (v2 == other.v2)
			&& (v3 == other.v3);
	}
	
	// Pretty print
	public override string ToString()
	{
		return $"[{v0}, {v1}, {v2}, {v3}]";
	}
	
}