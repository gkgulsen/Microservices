using Services.Basket.Dtos;
using Services.Basket.Services;
using Shared.Messages.Events.Course;
using System.Text.Json;

namespace Services.Basket.Consumers.Events
{
    public class CourseNameChangedEventConsumer //: IConsumer<CourseNameChangedEvent>
    {
        //private readonly RedisService _redisService;

        //public CourseNameChangedEventConsumer(RedisService redisService)
        //{
        //    _redisService = redisService;
        //}

        //public async Task Consume(ConsumeContext<CourseNameChangedEvent> context)
        //{
        //    var keys = _redisService.GetKeys();

        //    if (keys != null)
        //    {
        //        foreach (var key in keys)
        //        {
        //            var basket = await _redisService.GetDb().StringGetAsync(key);

        //            var basketDto = JsonSerializer.Deserialize<BasketDto>(basket);

        //            basketDto?.basketItems.ForEach(x =>
        //            {
        //                x.CourseName = x.CourseId == context.Message.CourseId ? context.Message.UpdatedName : x.CourseName;
        //            });

        //            await _redisService.GetDb().StringSetAsync(key, JsonSerializer.Serialize(basketDto));

        //        }
        //    }
        //}
    }
}
