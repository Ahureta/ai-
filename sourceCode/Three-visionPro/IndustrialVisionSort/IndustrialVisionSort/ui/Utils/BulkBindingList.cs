using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _9_11.UI.Utils
{
    public class BulkBindingList<T> : BindingList<T>
    {
        public BulkBindingList() : base() { }
        public BulkBindingList(IList<T> list) : base(list) { }

        public void ReplaceAll(IEnumerable<T> items)
        {
            bool old = RaiseListChangedEvents;
            RaiseListChangedEvents = false;   // 暂停逐个通知

            try
            {
                Clear();
                foreach (var item in items)
                    Add(item);
            }
            finally
            {
                RaiseListChangedEvents = old; // 恢复原状态
                if (RaiseListChangedEvents)
                    ResetBindings();          // 只触发一次全量刷新
            }
        }

        public void AddRange(IEnumerable<T> items)
        {
            bool old = RaiseListChangedEvents;
            RaiseListChangedEvents = false;

            try
            {
                foreach (var item in items)
                    Add(item);
            }
            finally
            {
                RaiseListChangedEvents = old;
                if (RaiseListChangedEvents)
                    ResetBindings();
            }
        }
    }
}
