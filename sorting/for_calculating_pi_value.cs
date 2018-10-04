using System;

 public  float PI ;
public class pi_generation
  {
    private pi_generation()
    {
       float sum = 0;
       for ( float i = 0 ; i < 5 ; i += 0.01)
       {
          sum +=  Math.Sqrt(i);
       }
       PI = sum * 4 / 25 ;
    }
  }
