using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace LabAssignment8
{
    // This program demo. how to Serialize and Deserialize objects of product class.
    class SerializeAndDeserialize
    {
        static void Main()
        {
            SerializeAndDeserialize serializeAndDeserialize = new SerializeAndDeserialize();
            serializeAndDeserialize.Deserialization();
            Console.WriteLine("Object is serialized successfully");
            Console.ReadLine();

        }
            public void Serialization()
            {
                try
                {
                    Product product = new Product { ProCode = 123, ProName = "kajal", ProCategory = "Makeup" };
                    FileInfo fileInfo = new FileInfo("product.dat");
                    FileStream fileStream = fileInfo.Open(FileMode.Open);

                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, product);
                    fileStream.Close();
                }
                catch (SerializationException ex) 
            {
               
            }
                public void DeSerialization()
            {
                try
                {
                    Product product = new Product();
                    FileInfo fileInfo = new FileInfo("product.dat");
                    using (FileStream fileStream = fileInfo(FileMode.Open)) 

                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                       product =(Product) binaryFormatter.Deserialize(fileStream);
                        Console.WriteLine($"Code={product.ProCode}\nName={product.ProNmae}\ncategory={product.ProCategory}");
                        fileStream.Close();
                    }

                }
                catch (Exception ex) { }

            }

        }

    }
}
