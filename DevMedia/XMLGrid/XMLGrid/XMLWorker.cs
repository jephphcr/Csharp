using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace XMLGrid
{

    public class XMLWorker
    {
        
        public const string ROOT_NODE = "___root";
    }

    public static Dictionary<string,string> LerXml(string file, out string error)
    {
        error = "";
        var ret = new Dictionary<string, string>();

        if (!File.Exists(file))
        {
            error = string.Format("O arquivo {0} não foi encontrado.", file);
            return ret;
        }

        try
        {
            using (XmlReader reader = XmlReader.Create(file))
            {
                while(reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if(reader.IsEmptyElement)
                        {
                            ret.Add("XML vazio", "");
                        }
                        else
                        {
                            if(reader.IsStartElement() && !ret.ContainsKey("___root"))
                            {
                                ret.Add("___root", reader.Name);
                            }
                            else if (!ret.ContainsKey(reader.Name))
                            {
                                ret.Add(reader.Name, reader.ReadString());
                            }
                        }
                    }
                    else if (!ret.ContainsKey(reader.Name))
                    {
                        ret.Add(reader.Name, reader.ReadContentAsString());
                    }
                }
            }
        }
        catch (Exception ex)
        {
            error = ex.Message;
        }

        return ret;

    }
}
