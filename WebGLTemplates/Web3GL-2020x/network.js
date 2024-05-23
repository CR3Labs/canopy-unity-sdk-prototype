// Used to set the network, chains can be found at: https://chainlist.org/
// Onboard JS chain config objects, set this to your build information

// interface Chain {
//   namespace?: 'evm';
//   id: ChainId;
//   rpcUrl: string;
//   label: string;
//   token: TokenSymbol;
//   color?: string;
//   icon?: string;
//   providerConnectionInfo?: ConnectionInfo;
//   publicRpcUrl?: string;
//   blockExplorerUrl?: string;
// }

window.networks = [
  {
    id: 5,
    label: "Ethereum Goerli",
    token: "goETH",
    rpcUrl: `https://goerli.infura.io/v3/d6375be451814c3289a59527da3f2c23`,
  }
]