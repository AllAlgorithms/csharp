using System;
using System.Collections.Generic;

namespace perceptron
{
    class Program
    {
        
        static int GetOutput(int[] inputs, List<double> weight){
            double result = 0;
            for (var i = 0; i >= inputs.Length; i++)
            {
                result += inputs[i] * weight[i];
            }
            return StepFunction(result);
        }

        static List<double> Learn(List<double> weight, double learningRate, int[] input, int erro){
            List<double> newWeight = new List<double>();
            for (var i = 0; i < input.Length; i++)
            {
                newWeight.Add(weight[i] + (learningRate*input[i]*erro));
            }
            return newWeight;
        }

        static int ErrorCalculate(int output, int expectedOutput){
            Console.WriteLine(Math.Abs(expectedOutput - output));
            return Math.Abs(expectedOutput - output);
        }

        static int StepFunction(double output){
            if (output > 0){
                return 1;
            }
            return 0;
        }
        static void Main(string[] args){
            var inputs = new List<int[]>{new [] {1,1},new [] {0,0},new[] {0,1}, new[] {1,0}};
            var expectedOutput = new List<int>{1, 0, 0, 0};
            var weight = new List<double>{0, 0};
            var learningRate = 0.1;
            var totalError = 1;
            while(totalError > 0)
            {
                Console.WriteLine("------------------");
                totalError = 0;
                for(var i = 0; i < inputs.Count; i++){
                    var output = GetOutput(inputs[i], weight);
                    var erro = ErrorCalculate(output, expectedOutput[i]);
                    totalError += erro;
                    weight = Learn(weight,learningRate, inputs[i], erro);
                    Console.WriteLine("expected output " + expectedOutput[i].ToString());  

                    Console.WriteLine("output " + output.ToString());  
                    Console.WriteLine("weight update error " + totalError.ToString());                    
                    foreach(var j in weight){
                        Console.WriteLine("\t"+j.ToString());
                    }
                }
            }
        }
    }
}
