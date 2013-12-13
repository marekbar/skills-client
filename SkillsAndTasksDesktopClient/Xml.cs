/**
 * Marek Bar
 * marekbar1985@gmail.com
 * Generic serializing
 * Save and/or restore object to/from xml
 **/
using System;
using System.IO;
namespace marekbar
{
    public enum XmlSerializeError
    {
        ARGUMENT_NULL,
        ARGUMENT_OUT_OF_RANGE,
        ARGUMENT_ERROR,
        PATH_TOO_LONG,
        MISSING_DIRECTORY,
        MISSING_FILE,
        SECURITY_ERROR,
        IO_ERROR,
        NOT_SUPPORTED,
        INVALID_OPERATION,
        GENERAL,
        NONE
    }
    public class Xml
    {
        public static XmlSerializeError Error = XmlSerializeError.NONE;
        public static String Message = "";
        public static Boolean Save<T>(T Source, String filename)
        {
            var backup = filename + ".backup";

            try
            {
                if (File.Exists(filename))
                {
                    File.Delete(backup);
                    try
                    {
                        File.Copy(filename, backup);
                    }
                    catch { }

                }
                using (var stream = new FileStream(filename, System.IO.FileMode.Create))
                {
                    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                    serializer.Serialize(stream, Source);
                }
                Error = XmlSerializeError.NONE;
                if (File.Exists(filename))
                {
                    File.Delete(backup);
                }
                return true;
            }
            catch (ArgumentNullException e)
            {
                Error = XmlSerializeError.ARGUMENT_NULL;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Error = XmlSerializeError.ARGUMENT_OUT_OF_RANGE;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (ArgumentException e)
            {
                Error = XmlSerializeError.ARGUMENT_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (System.Security.SecurityException e)
            {
                Error = XmlSerializeError.SECURITY_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (PathTooLongException e)
            {
                Error = XmlSerializeError.PATH_TOO_LONG;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (DirectoryNotFoundException e)
            {
                Error = XmlSerializeError.MISSING_DIRECTORY;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (FileNotFoundException e)
            {
                Error = XmlSerializeError.MISSING_FILE;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (IOException e)
            {
                Error = XmlSerializeError.IO_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (NotSupportedException e)
            {
                Error = XmlSerializeError.NOT_SUPPORTED;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (InvalidOperationException e)
            {
                Error = XmlSerializeError.INVALID_OPERATION;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (Exception e)
            {
                Error = XmlSerializeError.GENERAL;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            if (Error != XmlSerializeError.NONE)
            {
                if (File.Exists(filename) && File.Exists(backup))
                {
                    File.Delete(filename);
                    File.Copy(backup, filename);
                    File.Delete(backup);
                }
            }
            return false;
        }

        public static T Restore<T>(String filename) where T: new()
        {
            try
            {
                T data;
                using (var stream = new FileStream(filename, System.IO.FileMode.OpenOrCreate))
                {
                    var serializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
                    data = (T)serializer.Deserialize(stream);
                }
                Error = XmlSerializeError.NONE;
                return data;
            }
            catch (ArgumentNullException e)
            {
                Error = XmlSerializeError.ARGUMENT_NULL;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Error = XmlSerializeError.ARGUMENT_OUT_OF_RANGE;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (ArgumentException e)
            {
                Error = XmlSerializeError.ARGUMENT_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (System.Security.SecurityException e)
            {
                Error = XmlSerializeError.SECURITY_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (PathTooLongException e)
            {
                Error = XmlSerializeError.PATH_TOO_LONG;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (DirectoryNotFoundException e)
            {
                Error = XmlSerializeError.MISSING_DIRECTORY;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (FileNotFoundException e)
            {
                Error = XmlSerializeError.MISSING_FILE;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (IOException e)
            {
                Error = XmlSerializeError.IO_ERROR;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (NotSupportedException e)
            {
                Error = XmlSerializeError.NOT_SUPPORTED;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (InvalidOperationException e)
            {
                Error = XmlSerializeError.INVALID_OPERATION;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            catch (Exception e)
            {
                Error = XmlSerializeError.GENERAL;
                Message = e.Message + (e.InnerException != null ? "\n" + e.InnerException.Message : "");
            }
            return new T();
        }
    }
}
