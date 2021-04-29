namespace Microsoft.eShopWeb.ApplicationCore.Entities
{
    /// <summary>
    /// This can easily be modified to be BaseEntity<T> and public T Id to support different key types.
    /// Using non-generic integer types for simplicity and to ease caching logic
    /// 作为所有实体对象的基类
    /// 
    /// 通过定义一个BaseEntity，要求所有的实体继承它
    /// 为什么这样做?
    /// 因为实体的特征是具有唯一的身份标识,所以通过在父类来定义Id属性来实现。这也就是层超类型的实现方式
    /// 
    /// </summary>
    public abstract class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
