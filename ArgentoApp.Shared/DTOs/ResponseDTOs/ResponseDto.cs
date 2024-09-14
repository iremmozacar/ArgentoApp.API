using System;

namespace ArgentoApp.Shared.DTOs.ResponseDTOs;

public class ResponseDto<T>
{
public T Data { get; set; }
public string Error { get; set; }   
public int StatusCode { get; set; } 
public bool IsSucceeded { get; set; }   


public static ResponseDto<T> Success (T data, int StatusCode)
{
        return new ResponseDto<T>
        {
            Data = data,
            StatusCode = StatusCode,
            IsSucceeded = true
        };
}
    public static ResponseDto<T> Success(int StatusCode)
    {
        return new ResponseDto<T>
        {
        Data = default(T),
        StatusCode = StatusCode,
        IsSucceeded = true
        };
    }
}
