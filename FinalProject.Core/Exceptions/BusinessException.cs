﻿namespace FinalProject.Core.Exceptions;

public class BusinessException : Exception
{
    public BusinessException(string message) : base(message) { }
}