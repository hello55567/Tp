﻿namespace TeenPatti.Model
{
    public interface ISessionDatabase
    {
        long Authenticate(string sessionToken);

        void InValidate(string sessionToken);

        string CreateSession(long playerId);

        void InValidate(long userId);
    }
}