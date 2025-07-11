﻿using Nethereum.RPC.Eth.DTOs;
using System.Collections.Generic;
using System.Numerics;

namespace Nethereum.Contracts.CQS
{
    /// <summary>
    /// Base class used for the messages and descriptions of Deployments and Functions (Queries, Transactions)
    /// </summary>
    public abstract class ContractMessageBase
    {
        /// <summary>
        /// The Ether Amount to Send to the contract in Wei
        /// </summary>
        /// <remarks>
        /// The smart contract function will need to mark as payable in latest versions of solidity
        /// </remarks>
        public virtual BigInteger AmountToSend { get; set; }

        /// <summary>
        /// The Maximum Gas to use for the transaction
        /// </summary>
        public virtual BigInteger? Gas { get; set; }

        /// <summary>
        /// The Gas price per unit of Gas, only used in Legacy transactions
        /// </summary>
        public virtual BigInteger? GasPrice { get; set; }
        /// <summary>
        /// The address of the sender
        /// </summary>
        public virtual string FromAddress { get; set; }
        /// <summary>
        /// The unique number for the contract message transaction
        /// </summary>
        /// <remarks>
        /// Nonces are ordered based on the number of transactions from an specific account,
        /// so the next nonce for the next transaction will be the total number of transactions for that account
        /// </remarks>
        public virtual BigInteger? Nonce { get; set; }

        /// <summary>
        /// Max Fee Per Gas provided by the sender in Wei. Introduced in EIP 1559
        /// </summary>
        public virtual BigInteger? MaxFeePerGas { get; set; }

        /// <summary>
        ///   Max Priority Fee Per Gas provided by the sender in Wei. Introduced in EIP 1559
        /// </summary>
        public virtual BigInteger? MaxPriorityFeePerGas { get; set; }

        /// <summary>
        ///   The transaction type, null for legacy, 0x02 for EIP 1559
        /// </summary>
        public virtual byte? TransactionType { get;  set; }

        /// <summary>
        ///   Access list. Introduced in EIP 1559
        /// </summary>
        public virtual List<AccessList> AccessList { get; set; }

        /// <summary>
        ///  AuthorisationList. Introduced in EIP 7022
        /// </summary>
        public virtual List<Authorisation> AuthorisationList { get; set; }
    }
}