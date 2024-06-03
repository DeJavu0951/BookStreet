namespace Domain.Constants
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseStatus
    {
        Success = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        InternalServerError = 500,
    }

    /// <summary>
    /// 
    /// </summary>
    public enum ActionRow
    {
        ADD = 1,
        REMOVE = 2,
        UPDATE = 3
    }
}
