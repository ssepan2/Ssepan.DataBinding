using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Ssepan.Utility;

namespace Ssepan.DataBinding
{
    public static class ControlBindings
    {

        /// <summary>
        /// Bind ListControl to List<String>.
        /// </summary>
        /// <param name="listControl"></param>
        /// <param name="listOfString"></param>
        public static void BindListControlToListOfString(ListControl listControl, List<String> listOfString)
        {
            try
            {
                var list = (from String item in listOfString
                            select new { ValueMember = item, DisplayMember = item }).ToList();
                listControl.DataSource = list;
                listControl.DisplayMember = "DisplayMember";
                listControl.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                        
                throw;
            }
        }

        /// <summary>
        /// Bind ListControl to List<String>.
        /// </summary>
        /// <param name="listControl"></param>
        /// <param name="listOfString"></param>
        public static void BindListControlToBindingListOfString(ListControl listControl, BindingList<String> listOfString)
        {
            try
            {
                var list = (from String item in listOfString
                            select new { ValueMember = item, DisplayMember = item }).ToList();
                listControl.DataSource = list;
                listControl.DisplayMember = "DisplayMember";
                listControl.ValueMember = "ValueMember";
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                        
                throw;
            }
        }
        
        /// <summary>
        /// Bind ListControl to List Of T.
        /// </summary>
        /// <param name="listControl"></param>
        /// <param name="listOfString"></param>
        public static void BindListControlToListOfT<T>(ListControl listControl, List<T> list, String displayMember, String valueMember)
        {
            try
            {
                listControl.DataSource = list;
                listControl.DisplayMember = displayMember;
                listControl.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                        
                throw;
            }
        }
        
        /// <summary>
        /// Bind ListControl to BindingList Of T.
        /// </summary>
        /// <param name="listControl"></param>
        /// <param name="listOfString"></param>
        public static void BindListControlToBindingListOfT<T>(ListControl listControl, BindingList<T> list, String displayMember, String valueMember)
        {
            try
            {
                listControl.DataSource = list;
                listControl.DisplayMember = displayMember;
                listControl.ValueMember = valueMember;
            }
            catch (Exception ex)
            {
                Log.Write(ex, MethodBase.GetCurrentMethod(), EventLogEntryType.Error);
                        
                throw;
            }
        }
    }
}
