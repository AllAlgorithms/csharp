using System;

class Diagnostics {

  public bool Assert(bool Condition) {

    if (Condition == false)
      throw new System.ArgumentException("Invalid Argument");

    return true;

  } 
}

class FactorialSequence {

  private Diagnostics Test;

  public FactorialSequence() {

    Test = new Diagnostics();
  }

  public bool IsSpecialPosition(int Position) {

    return Position == 0 || Position == 1;
  }

  public int GetFactorialNumber(int Position) {

    Test.Assert(Position >= 0);

    if (IsSpecialPosition(Position))
      return 1;

    return Position * GetFactorialNumber(Position - 1);
  }
}

class TestFibonacci {

  private FactorialSequence Factorial;
  private Diagnostics Test;

  public TestFibonacci() {
    
    Factorial = new FactorialSequence();
    Test = new Diagnostics();
  }

  public void Test_GetFactorialNumber() {

    Test.Assert(Factorial.GetFactorialNumber(2) == 2);
    Test.Assert(Factorial.GetFactorialNumber(3) == 6);
    Test.Assert(Factorial.GetFactorialNumber(5) == 120);
    Test.Assert(Factorial.GetFactorialNumber(6) == 720);
  }
}

class MainClass {

  private static TestFibonacci testing = new TestFibonacci();

  public static void Main (string[] args) {

      testing.Test_GetFactorialNumber();

  }
}