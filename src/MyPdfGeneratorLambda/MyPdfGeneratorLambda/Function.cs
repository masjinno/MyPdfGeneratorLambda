using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using MyPdfGeneratorLambda.Dto;
using MyPdfGeneratorLambda.Model;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyPdfGeneratorLambda
{
    public class Function
    {
        /// <summary>
        /// CSV�t�@�C������PDF�t�@�C���𐶐�����
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public GeneratedPdf GeneratePdfFromCsv(PdfGenerationInput input, ILambdaContext context)
        {
            context.Logger.LogLine($"Arg : [{input}]");
            PdfGenerator generator = new PdfGenerator();
            return generator.GeneratePdfFromCsv(input);
        }

        /// <summary>
        /// PDF�t�@�C�������Ŏw��\�ȃp�����[�^�[���擾����
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public Properties GetProperties(object input, ILambdaContext context)
        {
            return Properties.Init();
        }
    }
}
