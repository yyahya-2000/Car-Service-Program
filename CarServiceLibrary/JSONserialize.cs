using System;
using System.Web.Script.Serialization;

namespace CarServiceLibrary
{
    /// <summary>
    /// seialization class
    /// </summary>
    public static class JSONserialize
    {
        /// <summary>
        /// serialize method
        /// </summary>
        /// <param name="tools">the array which will be sirialized</param>
        /// <returns>the string form of the array</returns>
        public static string Serialize(Tool[] tools)
        {
            JavaScriptSerializer dataContract = new JavaScriptSerializer();
            string serializedDataInStringFormat = dataContract.Serialize(tools);
            return serializedDataInStringFormat;
        }

        /// <summary>
        ///  deserialize method
        /// </summary>
        /// <param name="serializedDataInStringFormat">the string form or the array  or Tool objects</param>
        /// <returns>the array of Tool objects which was saved at string form</returns>
        public static Tool[] Deserialize(string serializedDataInStringFormat)
        {
            JavaScriptSerializer dataContract = new JavaScriptSerializer();
            Tool[] tools = dataContract.Deserialize<Tool[]>(serializedDataInStringFormat);
            return tools;
        }

    }
}
