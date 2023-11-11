using WarhouseView.Exceptions;

namespace WarhouseView.Middlewares
{
    public class PurityMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IPurityPattern _pattern;

        public PurityMiddleware(IPurityPattern pattern, RequestDelegate next)
        {
            _pattern = pattern;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                if (_pattern.MatchFound(context.Request.Path))
                {
                    context.Response.Redirect(_pattern.RedirectUrl);
                    throw new PurityException(_pattern.Message);
                }
                else
                {
                    await _next(context);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
