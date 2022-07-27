# CLSS.Types.MemoizedFunc

### Problem

Memoization is a common optimization technique for pure functions. Computed results are cached and retrieved on later invocations to save computation time. You can do this with any pure function by pairing it with a `Dictionary` that holds the cached results, but C# does not provide a convenient way to memoize pure functions in its syntax or its standard library.

### Solution

`MemoizedFunc` is a type that encapsulates any function with at least 1 argument and automatically takes care of the memoization process for you. Afterward, you can invoke the `MemoizedFunc` similarly to how you would invoke a `System.Func` object.

```
using CLSS;

public int Square(int x) { return x * x; }

var memoizedSquare = MemoizedFunc<int, int>.From(Square);
memoizedSquare.Invoke(4); // 16
// Also accepts lambda expressions
var memoizedCube = MemoizedFunc<int, int>.From(x => x * x * x);
```

The memoized result dictionary is publicly exposed, so you can even pre-populate it with known results.

```
using CLSS;

MemoizedFunc<int, int> Factorial = null;
Factorial = MemoizedFunc<int, int>.From(n => Factorial.Invoke(n - 1) * n);
Factorial.MemoizedResults[0] = 1;

// Benchmark
var startTime = DateTime.Now;
Factorial.Invoke(5000);
Console.WriteLine($"cold run: {(DateTime.Now - startTime).TotalMilliseconds}ms");
startTime = DateTime.Now;
Factorial.Invoke(5000);
Console.WriteLine($"hot run: {(DateTime.Now - startTime).TotalMilliseconds}ms");
// cold run: 4.0995ms
// hot run: 0.0175ms
```

`MemoizedFunc` does not and cannot check if the function it is encapsulating is pure or not. This should be ensured by you. Although by accepting impure functions, it can lead to some interesting use case.

```
using CLSS;
using UnityEngine;

// WaitForSeconds is a reference type, so s => new WaitForSeconds(s) is
// technically an impure function. However, WaitForSeconds instances with the
// same second value are interchangable in Unity. This saves on allocations.
public static MemoizedFunc<float, WaitForSeconds> WFSMemoizedGenerator
  = MemoizedFunc<float, WaitForSeconds>.From(s => new WaitForSeconds(s));
```

##### This package is a part of the [C# Language Syntactic Sugar suite](https://github.com/tonygiang/CLSS).