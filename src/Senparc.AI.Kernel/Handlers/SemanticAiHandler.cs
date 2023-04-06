using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.Orchestration;
using Microsoft.SemanticKernel.SemanticFunctions;
using Senparc.AI.Entities;
using Senparc.AI.Interfaces;
using Senparc.AI.Kernel;
using Senparc.AI.Kernel.Entities;
using Senparc.AI.Kernel.Handlers;
using Senparc.AI.Kernel.Helpers;
using System.Threading.Tasks;

namespace Senparc.AI.Kernel
{
    /// <summary>
    /// SenmanticKernel ������
    /// </summary>
    public class SemanticAiHandler :
        IAiHandler<SenparcAiRequest, SenparcAiResult, SenparcAiContext, ContextVariables>
    {
        public SemanticKernelHelper SemanticKernelHelper { get; set; }
        private IKernel _kernel => SemanticKernelHelper.GetKernel();

        public SemanticAiHandler(SemanticKernelHelper semanticAiHelper = null)
        {
            SemanticKernelHelper = semanticAiHelper ?? new SemanticKernelHelper();
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="request"><inheritdoc/></param>
        /// <returns></returns>
        public SenparcAiResult Run(SenparcAiRequest request)
        {
            //TODO:δ��ʽʹ��

            //TODO:�˷�����ʱ��������
            SemanticKernelHelper.ConfigTextCompletion(request.UserId, request.ModelName, null);

            var senparcAiResult = new SenparcAiResult();
            return senparcAiResult;
        }


        public async Task<IWantToRun> ChatConfigAsync(PromptConfigParameter promptConfigParameter, string userId, string modelName = "text-davinci-003")
        {
            var iWantToRun = await this.IWantTo()
                                    .ConfigModel(ConfigModel.TextCompletion, userId, modelName)
                                    .BuildKernel()
                                    .RegisterSemanticFunctionAsync(promptConfigParameter);
            return iWantToRun;
        }

        public async Task<SenparcAiResult> ChatAsync(IWantToRun iWantToRun, SenparcAiRequest request)
        {
            var aiResult = await iWantToRun.RunAsync(request);
            return aiResult;
        }
    }

}


