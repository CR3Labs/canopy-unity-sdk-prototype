using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using Newtonsoft.Json;

#if UNITY_WEBGL
public class TransferERC20 : MonoBehaviour
{
    private string Account;
    private string ProjectID;

    [SerializeField]
    private string contract = "0xC02aaA39b223FE8D0A0e5C4F27eAD9083C756Cc2";
    [SerializeField]
    private string toAccount = "0x8d62E8e44D63cd91ED02F1Cc90a01968b249e5B6";
    [SerializeField]
    private string amount = "1000000000";

    private readonly string abi = ABI.ERC_20;

    [DllImport("__Internal")]
    private static extern void SendContractJs(string method, string abi, string contract, string args, string value, string gasLimit, string gasPrice);
    
    void Start()
    {
        // loads the data saved
       ProjectID = PlayerPrefs.GetString("ProjectID");
       Account = PlayerPrefs.GetString("Account");
       Debug.Log("Account" + Account);
       Debug.Log("ProjectID" + ProjectID);
    }

    public void OnTransfer()
    {
        // smart contract method to call
        string method = "transfer";
        // array of arguments for contract
        string[] obj = { toAccount, amount };
        string args = JsonConvert.SerializeObject(obj);
        Debug.Log(args);
        // value in wei
        string value = "0";
        // gas limit OPTIONAL
        string gasLimit = "";
        // gas price OPTIONAL
        string gasPrice = "";
        // connects to user's browser wallet (metamask) to send a transaction
        try
        {
            //method, abi, contract, args, value, gasLimit, gasPrice
            SendContractJs(method, abi, contract, args, value, gasLimit, gasPrice);
            // Debug.Log(response);
        }
        catch (Exception e)
        {
            Debug.LogException(e, this);
        }
    }

}
#endif
