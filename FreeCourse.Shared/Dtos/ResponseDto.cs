using System;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.Dtos
{
	public class ResponseDto<T>
	{
		public T Data { get; set; }

		[JsonIgnore]
		public int StatusCode { get; set; }

		[JsonIgnore]
		public bool IsSuccessful { get; set; }

        public List<string> Errors { get; set; }




        //Static Factory Method
        public static ResponseDto<T> Success(T data, int statusCode)
        {

            return new ResponseDto<T>
            {
                Data = data,
                IsSuccessful = true,
                StatusCode = statusCode
            };
        }
    

        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> {
                Data = default(T),
                IsSuccessful = true,
                StatusCode = statusCode };
        }


        public static ResponseDto<T> Fail(List<string> error, int statusCode)
        {
            return new ResponseDto<T>
            {
                 Errors = error,
                 StatusCode = statusCode,
                 IsSuccessful = false,
            };
        }

        
        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T>
            {
                Errors = new List<string>() { error },
                IsSuccessful = false,
                StatusCode = statusCode
            };
        }




    }

}
    

