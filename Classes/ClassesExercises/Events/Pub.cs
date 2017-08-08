using System;

namespace Events
{
    public class Pub
    {
        public int Value { get; set; }
        internal event EventHandler<MyArgs> OnChange = delegate {};
        public Pub(int value)
        {
            Value = value;
        }
        /// <summary>
        /// Validates if event is distint that null and notify to observers
        /// about changes.
        /// </summary>
        public void NotifyObservers()
        {
            OnChange?.Invoke(this, new MyArgs(Value));
        }
    }
}
