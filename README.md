# F# Mutable Variable Swap Bug

This repository demonstrates a common error when working with mutable variables in F#.  The `swap` function appears to correctly swap two integers, but due to F#'s pass-by-reference semantics for mutable variables, the result is not as expected.

The `bug.fs` file contains the buggy code, and `bugSolution.fs` provides the corrected version.

## How to reproduce

1. Clone the repository.
2. Open `bug.fs` in an F# compiler or IDE (e.g., .NET interactive, Visual Studio).
3. Run the code. Observe that the output isn't the expected swap.

## Solution

The solution involves using a tuple to return the swapped values. Since tuples are value types, they are passed by value and the original variables remain unchanged.