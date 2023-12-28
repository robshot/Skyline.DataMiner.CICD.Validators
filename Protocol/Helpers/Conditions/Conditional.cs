﻿// <auto-generated>
// Do not change. Treat this as auto-generated code as this is converted from code in DataMiner.
// If there are software changes this allows easier comparison.
// </auto-generated>
namespace SLDisValidator2.Helpers.Conditions
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read.Interfaces;

    class Conditional
    {
        private readonly Action<string> addInvalidConditionError;
        private readonly Action<string> addInvalidIdError;
        private readonly Action addConditionCanBeSimplifiedWarning;

        public Conditional(Action<string> addInvalidConditionError, Action<string> addInvalidIdError, Action addConditionCanBeSimplifiedWarning)
        {
            this.addInvalidConditionError = addInvalidConditionError;
            this.addInvalidIdError = addInvalidIdError;
            this.addConditionCanBeSimplifiedWarning = addConditionCanBeSimplifiedWarning;
        }

        List<Condition> m_ppaConditions;

        private string originalCondition;

        public bool ParseConditional(string strCondition)
        {
            try
            {
                int iOpenCount = 0;
                int iCloseCount = 0;
                int iConditionPosition = 0;
                int iOpenPosition = 0;

                int bLastOpen = 0;

                originalCondition = strCondition;

                string strThisCondition = strCondition;
                string strNewCondition = strCondition;

                Condition pTmpCondition = null;

                bool bWithinQuote = false;
                bool bHadSlash = false;
                bool bHadParenthesesWithinQuotes = false;

                while (strThisCondition.IndexOf("(", 0) != -1)
                {
                    for (int i = 0; i < strThisCondition.Length; i++)
                    {
                        switch (strThisCondition[i])
                        {
                            case '(':
                                {
                                    if (!bWithinQuote)
                                    {
                                        bLastOpen = 1;
                                        iOpenCount++;
                                        iOpenPosition = i;
                                    }
                                    else bHadParenthesesWithinQuotes = true;
                                    bHadSlash = false;
                                    break;
                                }
                            case ')':
                                {
                                    if (!bWithinQuote)
                                    {
                                        if (bLastOpen == 1)
                                        {
                                            // We have found a standalone condition ...
                                            string innerCondition = strThisCondition.Substring(iOpenPosition, (i - iOpenPosition) + 1);

                                            Condition pConditionB = ParseCondition(innerCondition);

                                            if (m_ppaConditions == null)
                                            {
                                                m_ppaConditions = new List<Condition>();
                                            }

                                            if (m_ppaConditions != null)
                                            {
                                                iConditionPosition = m_ppaConditions.Count;
                                                m_ppaConditions.Add(pConditionB);
                                            }
                                        }

                                        bLastOpen = 2;
                                        iCloseCount++;
                                    }
                                    else bHadParenthesesWithinQuotes = true;
                                    bHadSlash = false;

                                    break;
                                }
                            case '\'':
                            case '"':
                                {
                                    if (!bHadSlash)
                                        bWithinQuote = !bWithinQuote;
                                    else
                                    {
                                        // Remove the slash.
                                        strThisCondition = strThisCondition.Remove(i - 1, 1);
                                        strNewCondition = strThisCondition;
                                        i--;
                                    }
                                    bHadSlash = false;
                                    break;
                                }
                            case '\\':
                                {
                                    bHadSlash = true;
                                    break;
                                }
                            default:
                                {
                                    bHadSlash = false;
                                    break;
                                }
                        }
                    }

                    int iTmpPos = 0;

                    for (int iStartCondition = 0; m_ppaConditions != null && iStartCondition <= (m_ppaConditions.Count - 1); iStartCondition++)
                    {
                        pTmpCondition = m_ppaConditions[iStartCondition];

                        if (pTmpCondition != null)
                        {
                            iTmpPos = strNewCondition.IndexOf(pTmpCondition.StrData, 0);

                            if (iTmpPos != -1)
                            {
                                strNewCondition = strNewCondition.Remove(iTmpPos, pTmpCondition.StrData.Length);

                                string strTmpCondition = String.Format("#{0}#", iStartCondition);

                                strNewCondition = strNewCondition.Insert(iTmpPos, strTmpCondition);
                            }
                        }
                    }

                    if (strThisCondition != strNewCondition)
                    {
                        strThisCondition = strNewCondition;
                    }
                    else
                    {
                        if (!bHadParenthesesWithinQuotes)
                            strThisCondition = "";
                        else
                            break;
                    }

                    bHadSlash = false;
                    bWithinQuote = false;
                    bHadParenthesesWithinQuotes = false;
                }

                Condition pCondition = ParseCondition(strThisCondition);

                if (m_ppaConditions == null)
                {
                    m_ppaConditions = new List<Condition>();
                }

                if (pCondition != null && m_ppaConditions != null)
                {
                    m_ppaConditions.Add(pCondition);
                }

                if (iOpenCount != iCloseCount)
                {
                    throw new InvalidConditionException("Number of opening parentheses '(' does not match number of closing parentheses ')'.");
                }
            }
            catch (InvalidConditionException e)
            {
                addInvalidConditionError(e.Message);
            }

            return false;
        }

        public bool CheckConditional(IProtocolModel protocolModel)
        {
            bool bOk = false;

            try
            {
                if (m_ppaConditions == null || m_ppaConditions.Count == 0)
                {
                    return true;
                }

                if (m_ppaConditions.Count > 0)
                {
                    Condition pCondition = m_ppaConditions[m_ppaConditions.Count - 1];

                    Variant varValue = pCondition.Perform(m_ppaConditions.ToArray(), protocolModel);

                    if (varValue.Type == VariantType.VT_BOOL)
                    {
                        bOk = varValue.BooleanValue.Value;
                    }
                    else
                    {
                        throw new InvalidConditionException("Condition '" + originalCondition + "' is not a boolean expression.");
                    }
                }
            }
            catch (InvalidConditionException e)
            {
                if (e.Message != null && e.Message.StartsWith("Referenced parameter does not exist. Parameter ID: "))
                {
                    addInvalidIdError(e.Message.Substring(51));
                }
                else
                {
                    addInvalidConditionError(e.Message);
                }
            }

            return bOk;
        }

        private Condition ParseCondition(string innerCondition)
        {
            return new Condition(innerCondition, addConditionCanBeSimplifiedWarning);
        }
    }
}