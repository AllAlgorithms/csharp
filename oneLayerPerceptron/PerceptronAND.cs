using System;
using System.Collections.Generic;

namespace oneLayerPerceptron
{
    class PerceptronAND
    {
        
        static double GetOutput(double[] inputs, List<double> weight){
            double result = 0;
            for (var i = 0; i < inputs.Length; i++)
            {
                result += inputs[i] * weight[i];
            }
            return StepFunction(result);
        }

        static List<double> Learn(List<double> weight, double learningRate, double[] input, double erro){
            List<double> newWeight = new List<double>();
            for (var i = 0; i < weight.Count; i++)
            {
                var pesoNovo = weight[i] + (learningRate*input[i]*erro);
                newWeight.Add(pesoNovo);
                Console.WriteLine("weight updated "+pesoNovo.ToString());
            }
            return newWeight;
        }

        static double ErrorCalculate(double output, double expectedOutput){
            var erro = Math.Abs(expectedOutput - output);
            return erro;
        }

        static double StepFunction(double output){
            if (output >= 1){
                return 1;
            }
            return 0;
        }
        static void Main(string[] args){
            var inputs = new List<double[]>{new [] {0.0,0.0},new[] {0.0,1.0}, new[] {1.0,0.0},new [] {1.0,1.0}};
            var expectedOutput = new List<double>{0, 0, 0, 1};
            var weight = new List<double>{0, 0};
            var learningRate = 0.1;
            var totalError = 1.0;
            while(totalError != 0.0)
            {
                Console.WriteLine("------------------");
                totalError = 0.0;
                for(var i = 0; i < expectedOutput.Count; i++){
                    var output = GetOutput(inputs[i], weight);
                    var erro = ErrorCalculate(output, expectedOutput[i]);
                    totalError += erro;
                    weight = Learn(weight,learningRate, inputs[i], erro);
                }
                Console.WriteLine("total error " + totalError.ToString()); 
            }
        }
    }
}
