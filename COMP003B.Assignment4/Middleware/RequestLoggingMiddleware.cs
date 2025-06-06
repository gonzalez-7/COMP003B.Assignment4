﻿namespace COMP003B.Assignment4.Middleware
{
	public class RequestLoggingMiddleware
	{
		private readonly RequestDelegate _next;

		public RequestLoggingMiddleware(RequestDelegate next) => _next = next;

		public async Task InvokeAsync(HttpContext context)
		{
			Console.WriteLine($"Request: {context.Request.Method} {context.Request.Path}");
			await _next(context);
		}
	}
}
