﻿namespace TeenPatti.Infrastructure
{
    public class RaindropMIG : IIdGenerator
    {
        public long GetNextId()
        {
            var raindrop = new RainDrop();
            return raindrop.GetNextId();
        }
    }
}