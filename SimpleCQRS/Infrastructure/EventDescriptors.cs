﻿using System;
using System.Collections.Generic;
using SimpleCQRS.Domain;

namespace SimpleCQRS.Infrastructure
{
    public class EventDescriptors : Entity, IEnumerable<EventDescriptor>
    {
        private readonly List<EventDescriptor> descriptors;

        public EventDescriptor this[int key]
        {
            get { return descriptors[key]; }
            set { descriptors[key] = value; }
        }

        public EventDescriptors()
        {
            descriptors = new List<EventDescriptor>();
        }

        public void Add(EventDescriptor eventDescriptor)
        {
            descriptors.Add(eventDescriptor);
        }

        public IEnumerator<EventDescriptor> GetEnumerator()
        {
            return descriptors.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return descriptors.GetEnumerator();
        }
    }

    public class EventDescriptor
    {
        public Event EventData { get; set; }
        public Guid Id { get; set; }
        public int Version { get; set; }

        public EventDescriptor(Guid id, Event eventData, int version)
        {
            Id = id;
            EventData = eventData;
            Version = version;
        }

        public EventDescriptor()
        {
        }
    }
}
