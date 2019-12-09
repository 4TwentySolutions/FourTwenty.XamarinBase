﻿using Fusillade;

namespace XamBasePacket.Interfaces.Api
{
    public interface IExtendedApiService<out T> : IApiService<T>
    {
        T GetApi(IHttpClientOptions clientOptions);
    }
    public interface IApiService<out T>
    {
        T GetApi(Priority priority);
    }
}
