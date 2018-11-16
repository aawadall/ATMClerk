using System;
using System.Collections.Generic;

namespace Events
{
    /// <summary>
    /// Interface used to access the immutable Events Store
    /// </summary>
    public interface IEventList
    {
        /// <summary>
        /// Stores an event in events list
        /// </summary>
        /// <param name="cashEvent"></param>
        /// <returns>Key to newly stored event</returns>
        IEventKey Store(ICashEvent cashEvent);
        /// <summary>
        /// Searches for one or more events given an event key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        List<ICashEvent> Find(IEventKey key);
    }
}