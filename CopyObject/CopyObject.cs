using System;

namespace CopyObject
{
    public static class CopyObject
    {
        /// <summary>
        /// copy object properties
        /// </summary>
        /// <param name="self">this</param>
        /// <param name="parent">parent object</param>
        public static void CopyObjectFrom(this object self, object parent)
        {
            var fromProperties = parent.GetType().GetProperties();
            var toProperties = self.GetType().GetProperties();

            foreach (var fromProperty in fromProperties)
            {
                foreach (var toProperty in toProperties)
                {
                    if (fromProperty.Name == toProperty.Name && fromProperty.PropertyType == toProperty.PropertyType)
                    {
                        toProperty.SetValue(self, fromProperty.GetValue(parent));
                        break;
                    }
                }
            }
        }
    }
}
