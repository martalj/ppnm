Exam problem 13: Yet another cubic subspline.

In this project a subspline has been built, using a quadratic "inner" spline through all points but the first and last in groups of threes and then a cubic "outer" spline through all points.
For the quadratic polynomial, the derivative of each point was found. For the first and last point, the derivative of the second and second to last point, respectively, was used. 

The cubic subspline is given by
S_i(x) = y_i + b_i(x-x_i) + c_i(x-x_i)^2 + d_i(x-x_i)^3
The three coefficients are determined by three conditions:
S_i(x_i+1) = y_i+1
S'_i(x_i) = p_i
S'_i(x_i+1) = p_i+1

where p_i is the derivative of the point x_i found with the quadratic spline. The coefficients are found to be

b_i = p_i
c_i = 3dy_i/dx_i^2 -p_i/dx_i - 1/3dp_i/dx_i
d_i = dp_i/dx_i^2 - 2dy_i/dx_i^3 + 2p_i/dx_i^2

where dy_i = y_i+1 - y_i, dx_i = x_i+1 - x_i and dp_i = p_i+1 - p_i.

The resulting graphs can be seen in the .png files labelled spline 1,2,3 and 4. In these different data has been used to check how the subspline behaves. In the first figure, the spline is plotted along withthe integral and derivative. This is just x^2, so it is not superinteresting to look at. In the other three, more interesting data is used and the subspline is plotted along with a plain quadratic spline and a plain cubic spline. In the second figure the derivative and integral are also plotted, but have been omitted in the third and fourth figure for easier readability. It is clear that the quadratic spline is very bad at handling jumps in the data. While the cubic spline does an all right job, the subspline is definitely the best.

Overall, I have done the entire project well, including the extra assignment and also compared them to the plain splines from the homework assignment. My coding could have been cleaner and possibly there are easier or more effective ways to solve this problem, but my solution works excellently. I would give this project a 9/10 points.
