using System.Collections.Generic;
using System.Linq;
using Acs0;
using AElf.OS.Node.Application;
using AElf.Types;

namespace AElf.Blockchains.MainChain
{
    public partial class GenesisSmartContractDtoProvider
    {
        public IEnumerable<GenesisSmartContractDto> GetGenesisSmartContractDtosForRandomDemo(Address zeroContractAddress)
        {
            var l = new List<GenesisSmartContractDto>();

            l.AddGenesisSmartContract(
                _codes.Single(kv=>kv.Key.Contains("RandomDemo")).Value,
                Hash.FromString("AElf.ContractNames.RandomDemoContract"), new SystemContractDeploymentInput.Types.SystemTransactionMethodCallList());

            return l;
        }
    }
}