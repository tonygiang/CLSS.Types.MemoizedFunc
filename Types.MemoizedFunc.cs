// A part of the C# Language Syntactic Sugar suite.

using System.Collections.Generic;
using System;

namespace CLSS
{
  /// <summary>
  /// Encapsulates a <see cref="Func{T, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<T1, TResult> MemoizedResults
      = new Dictionary<T1, TResult>();
    protected Func<T1, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, TResult}"/> from a 1-argument
    /// function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, TResult}"/>.</returns>
    public static MemoizedFunc<T1, TResult> From(
      Func<T1, TResult> func)
    {
      return new MemoizedFunc<T1, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1)
    {
      if (!MemoizedResults.ContainsKey(arg1))
      {
        var result = _func(arg1);
        MemoizedResults[arg1] = result;
        return result;
      }
      return MemoizedResults[arg1];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2), TResult> MemoizedResults
      = new Dictionary<(T1, T2), TResult>();
    protected Func<T1, T2, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, TResult}"/>
    /// from a 2-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, TResult}"/>.</returns>
    public static MemoizedFunc<T1, T2, TResult> From(
      Func<T1, T2, TResult> func)
    {
      return new MemoizedFunc<T1, T2, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2)))
      {
        var result = _func(arg1, arg2);
        MemoizedResults[(arg1, arg2)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3), TResult>();
    protected Func<T1, T2, T3, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, TResult}"/>
    /// from a 3-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, TResult> From(
      Func<T1, T2, T3, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3)))
      {
        var result = _func(arg1, arg2, arg3);
        MemoizedResults[(arg1, arg2, arg3)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4), TResult>();
    protected Func<T1, T2, T3, T4, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, TResult}"/>
    /// from a 4-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, TResult> From(
      Func<T1, T2, T3, T4, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4)))
      {
        var result = _func(arg1, arg2, arg3, arg4);
        MemoizedResults[(arg1, arg2, arg3, arg4)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5), TResult>();
    protected Func<T1, T2, T3, T4, T5, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, TResult}"/>
    /// from a 5-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, TResult> From(
      Func<T1, T2, T3, T4, T5, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, TResult}"/>
    /// from a 6-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, TResult}"/>
    /// from a 7-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/>
    /// from a 8-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)]
          = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/>
    /// from a 9-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/>
    /// from a 10-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/>
    /// from a 11-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T12">The type of the 12th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/>
    /// from a 12-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <param name="arg12">The 12th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11, arg12)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11, arg12)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T12">The type of the 12th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T13">The type of the 13th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/>
    /// from a 13-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <param name="arg12">The 12th argument for the encapsulated function.
    /// </param>
    /// <param name="arg13">The 13th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
      T13 arg13)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11, arg12, arg13)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11, arg12, arg13)];
    }
  }


  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T12">The type of the 12th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T13">The type of the 13th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T14">The type of the 14th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/>
    /// from a 14-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <param name="arg12">The 12th argument for the encapsulated function.
    /// </param>
    /// <param name="arg13">The 13th argument for the encapsulated function.
    /// </param>
    /// <param name="arg14">The 14th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
      T13 arg13, T14 arg14)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11, arg12, arg13, arg14)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T12">The type of the 12th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T13">The type of the 13th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T14">The type of the 14th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T15">The type of the 15th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/>
    /// from a 15-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <param name="arg12">The 12th argument for the encapsulated function.
    /// </param>
    /// <param name="arg13">The 13th argument for the encapsulated function.
    /// </param>
    /// <param name="arg14">The 14th argument for the encapsulated function.
    /// </param>
    /// <param name="arg15">The 15th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
      T13 arg13, T14 arg14, T15 arg15)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14, arg15);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14, arg15)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11, arg12, arg13, arg14, arg15)];
    }
  }

  /// <summary>
  /// Encapsulates a <see cref="Func{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/>
  /// and its memoized results. This class is best used to encapsulate pure
  /// functions.
  /// </summary>
  /// <typeparam name="T1">The type of the 1st argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T2">The type of the 2nd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T3">The type of the 3rd argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T4">The type of the 4th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T5">The type of the 5th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T6">The type of the 6th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T7">The type of the 7th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T8">The type of the 8th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T9">The type of the 9th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T10">The type of the 10th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T11">The type of the 11th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T12">The type of the 12th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T13">The type of the 13th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T14">The type of the 14th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T15">The type of the 15th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="T16">The type of the 16th argument of the encapsulated
  /// function.</typeparam>
  /// <typeparam name="TResult">The return of of the encapsulated function.
  /// </typeparam>
  public partial class MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
  {
    /// <summary>
    /// The memoized results of the encapsulated function.
    /// </summary>
    public IDictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResult> MemoizedResults
      = new Dictionary<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16), TResult>();
    protected Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> _func = null;

    /// <summary>
    /// Creates a <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/>
    /// from a 16-argument function.
    /// </summary>
    /// <param name="func">The function to be encapsulated.</param>
    /// <returns>A new <see cref="MemoizedFunc{T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult}"/>.
    /// </returns>
    public static MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> From(
      Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
    {
      return new MemoizedFunc<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>
      { _func = func };
    }

    /// <summary>
    /// If the current combination of arguments does not already have a
    /// matching result memoized, invokes the encapsulated function with the
    /// current combination of arguments, memoizes and returns the result.
    /// Otherwise, returns the memoized result that match the current
    /// combination of arguments.
    /// </summary>
    /// <param name="arg1">The 1st argument for the encapsulated function.
    /// </param>
    /// <param name="arg2">The 2nd argument for the encapsulated function.
    /// </param>
    /// <param name="arg3">The 3rd argument for the encapsulated function.
    /// </param>
    /// <param name="arg4">The 4th argument for the encapsulated function.
    /// </param>
    /// <param name="arg5">The 5th argument for the encapsulated function.
    /// </param>
    /// <param name="arg6">The 6th argument for the encapsulated function.
    /// </param>
    /// <param name="arg7">The 7th argument for the encapsulated function.
    /// </param>
    /// <param name="arg8">The 8th argument for the encapsulated function.
    /// </param>
    /// <param name="arg9">The 9th argument for the encapsulated function.
    /// </param>
    /// <param name="arg10">The 10th argument for the encapsulated function.
    /// </param>
    /// <param name="arg11">The 11th argument for the encapsulated function.
    /// </param>
    /// <param name="arg12">The 12th argument for the encapsulated function.
    /// </param>
    /// <param name="arg13">The 13th argument for the encapsulated function.
    /// </param>
    /// <param name="arg14">The 14th argument for the encapsulated function.
    /// </param>
    /// <param name="arg15">The 15th argument for the encapsulated function.
    /// </param>
    /// <param name="arg16">The 16th argument for the encapsulated function.
    /// </param>
    /// <returns>The new value, or the memoized value that matches the current
    /// combination of arguments</returns>
    public virtual TResult Invoke(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5,
      T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12,
      T13 arg13, T14 arg14, T15 arg15, T16 arg16)
    {
      if (!MemoizedResults.ContainsKey((arg1, arg2, arg3, arg4, arg5, arg6,
        arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)))
      {
        var result = _func(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
        MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
          arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)] = result;
        return result;
      }
      return MemoizedResults[(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8,
        arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16)];
    }
  }
}