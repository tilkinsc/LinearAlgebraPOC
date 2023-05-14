# LinearAlgebraPOC

This is a proof of concept project. A learning project.

The goal of this project is not only to learn, but demonstrate the concepts in an easy to grasp way.
- Spice up the syntax for readability
- Comments clearly describing to a strong degree what the operation is doing, even if seemingly redundant
- Organized, spaced code
- Keep complex/nested/cluttered code to a minimum (no use of functional-esque functions)

I fully understand how using SIMD could speed up the library, but this was not a goal.

What I have learned
- When two vectors are added or subtracted, from the 'origin of the first vector to the end point of the second vector' a hypotenuse can be drawn in which a new vector is formed. This new vector represents how far the resulting sum or difference of the two vectors is as a point. A triangle is typically formed unless the vectors have the same components. Irregardless, x^2 + y^2 + ... = h^2 (h = sqrt(x^2 + y^2 + ...)) can be used to determine the length of the hypotenuse and thus the distance the two vectors cover.

