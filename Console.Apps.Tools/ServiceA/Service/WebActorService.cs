﻿using Akka.Actor;
using System;
using System.Threading.Tasks;

namespace ServiceB.Service
{
    public class WebActorService : IWebActorService
    {
        private readonly IActorRef webActorRef;

        public WebActorService()
        {

        }
        public WebActorService(IActorRef webActor)
        {
            this.webActorRef = webActor;
        }

        public Task<T> Ask<T>(object message, TimeSpan? timeout = null)
        {
            return webActorRef.Ask<T>(message, timeout);
        }
    }
}
