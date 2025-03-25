using CorporatePortalApi.Errors;

namespace CorporatePortalApi.Errors
{
	public class ErrorCodes
	{
		public static APIError NotFound()
		{
			return new APIError
			{
				ErrorCode = StatusCodes.Status404NotFound,
				ErrorMessage = "Not found!"
			};
		}

		public static APIError UnauthorizedAccess()
		{
			return new APIError
			{
				ErrorCode = StatusCodes.Status401Unauthorized,
				ErrorMessage = "Unauthorized access!"
			};
		}

		public static APIError BadRequestError(string message, string details = null)
		{
			return new APIError
			{
				ErrorCode = StatusCodes.Status400BadRequest,
				ErrorMessage = message,
				ErrorDetails = details
			};
		}

		public static APIError ServerError(string message = "An unexpected error occurred!")
		{
			return new APIError
			{
				ErrorCode = StatusCodes.Status500InternalServerError,
				ErrorMessage = message
			};
		}
	}
}

