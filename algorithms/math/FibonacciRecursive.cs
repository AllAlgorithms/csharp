using System;

class Diagnostics {

  public bool Assert(bool Condition) {

    if (Condition == false)
      throw new System.ArgumentException("Invalid Argument");

    return true;

  } 
}

class FibonacciSequence {

  private Diagnostics Test;

  public FibonacciSequence() {

    Test = new Diagnostics();
  }

  public bool IsSpecialPosition(int Position) {

    return Position == 1 || Position == 2;
  }

  public int GetFibonacciNumber(int Position) {

    Test.Assert(Position >= 0);

    if (IsSpecialPosition(Position))
      return 1;

    return GetFibonacciNumber(Position - 1) + GetFibonacciNumber(Position - 2);
  }

}

class TestFibonacci {

  private FibonacciSequence Fibonacci;
  private Diagnostics Test;

  public TestFibonacci() {
    
    Fibonacci = new FibonacciSequence();
    Test = new Diagnostics();
  }

  public void Test_GetFactorialNumber() {

    Test.Assert(Fibonacci.GetFibonacciNumber(3) == 2);
    Test.Assert(Fibonacci.GetFibonacciNumber(12) == 144);
    Test.Assert(Fibonacci.GetFibonacciNumber(5) == 5);
    Test.Assert(Fibonacci.GetFibonacciNumber(9) == 34);
  }
}

class MainClass {

  private static TestFibonacci testing = new TestFibonacci();

  public static void Main (string[] args) {

      testing.Test_GetFactorialNumber();

  }
}