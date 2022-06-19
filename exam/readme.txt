Exam problem 13: Yet another cubic sub-spline

"Introduction
    The ordinary cubic spline simetimes makes unpleasant wiggles, for example, around an outlier, or around a step-like feature of the tabulated function (read the Akima sub-spline chapter in the lecture notes). Here is yet another attempt to reduce the wiggles by building a sub-spline. 
Problem
    Consider a data set {xi, yi}i=1,..,n which represents a tabulated function.

    Implement a sub-spline of this data using the following algorithm:

        For each inner point xi, i=2,..,n-1, build a quadratic interpolating polynomial through the points xi-1, xi, xi+1 and estimate, using this polynomial, the first derivative, pi, of the function at the point xi;
        For the the first and the last points estimate p1 and pn from the the same polynomial that you used to estimate correspondingly p2 and pn-1.
        Now you have a data set {xi, yi, pi}i=1,..,n where the function is tabulated together with its derivative: build a cubic sub-spline for it,

        Si(x)= yi +bi(x-xi) +ci(x-xi)2 +di(x-xi)3,
        where for each interval the three coefficients bi, ci, di are determined by the three conditions,

        Si(xi+1)=yi+1,
        S'i(xi)=pi,
        S'i(xi+1)=pi+1.

Extra
    Derivative and integral of the spline."

In this project a subspline has been built, using a quadratic "inner" spline through all points in groups of threes and then a cubic "outer" spline through all points.
