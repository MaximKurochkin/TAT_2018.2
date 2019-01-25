using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    /// <summary>
    /// Class FinderOfIPinStr
    /// returns list with ip-address in string
    /// </summary>
    
    class FinderOfIPinStr
    {
        /// <summary>
        /// Method GetIPFromStr
        /// returns list with ip-address in string
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns>list with ip's from string</returns>
        
        public List<string> GetIPFromStr(string str)
        {
            List<string> listOfIP = new List<string>();
            StringBuilder ip = new StringBuilder();
            string octet = string.Empty;
            int countOfOctetes = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if(str[i] >= 48 && str[i] <= 57)
                {
                    octet = GetTheOctet(str, i);
                    if (octet == null)
                    {
                        continue;
                    }
                    else
                    {
                        if (octet.Length == 3)
                        {
                            int octetInInt = Convert.ToInt32(octet.ToString());
                            
                            if (octetInInt > 255)
                            {
                                ip.Clear();
                                countOfOctetes = 0;
                                i = i + octet.Length;
                                continue;
                            }
                        }
                        ip.Append(octet);
                        ip.Append('.');
                        countOfOctetes++;
                        i = i + octet.Length;

                        if (countOfOctetes >= 4)
                        {
                            countOfOctetes = 0;
                            ip.Remove(ip.Length - 1, 1);
                            listOfIP.Add(ip.ToString());
                            ip.Clear();
                        }
                        else if (i == str.Length)
                        {
                            ip.Clear();
                            Console.WriteLine("End of str");
                        }
                        else if (!(str[i + 1] >= 48 && str[i + 1] <= 57))
                        {
                            countOfOctetes = 0;
                            ip.Clear();
                        }
                    }
                }
                else
                {
                    continue;
                }
            }
            return listOfIP;
        }

        /// <summary>
        /// Method GetTheOctet
        /// return octet of ip-address
        /// </summary>
        /// <param name="str">input string</param>
        /// <param name="ind">current index of string</param>
        /// <returns>octet of ip-address</returns>
        
        private string GetTheOctet (string str, int ind)
        {
            StringBuilder octet = new StringBuilder();
            int lengthOfStr = str.Length;
            while(str[ind] >= 48 && str[ind] <= 57)
            {

                octet.Append(str[ind]);
                if(ind == lengthOfStr - 1)
                {
                    return octet.ToString();
                }
                ind++;
                
                if(octet.Length > 3)
                {
                    return null;
                }
            }
            return octet.ToString();
        }
    }
}
