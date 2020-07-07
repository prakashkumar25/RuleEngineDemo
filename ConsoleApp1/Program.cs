using System;
using System.Data;
using System.Drawing;
using System.Linq;
using DotNetRuleEngine;
using DotNetRuleEngine.Exceptions;
using DotNetRuleEngine.Extensions;
using DotNetRuleEngine.Interface;

namespace ConsoleApp1
{
    class Program
    {
        public class LinkedList
        {
            LinkedList Head;
            public class Node
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Entity : Object
        {
            public static int  value;
            static Entity()
            {
                value = 0;   
            }

            public Entity()
            {
                value = 0;
            }
            public Guid Id { get; set; }

            public override bool Equals(object obj)
            {
                return true;
            }
        }
        
        public class User : Entity
        {
            public string Name { get; set; }
            public string DateOfBirth { get; set; }
        }

        public interface IEntityRepository<TEntity> where TEntity : Entity
        {
            TEntity GetId(Guid id);
        }

        public class EntityRepository : IEntityRepository<Entity>
        {
            public virtual Entity GetId(Guid id)
            {
                return new Entity();
            }
        }

        public class UserRepository : IEntityRepository<User>
        {
            public User GetId(Guid id)
            {
                return new User();
            }
        }

        public interface IEqualityComparor<in TEntity> where TEntity: Entity
        {
            bool Equals(TEntity left, TEntity right);
        }

        public class CompareEntity : IEqualityComparor<Entity>
        {
            public bool Equals(Entity left, Entity right)
            {
                return left.Id == right.Id;
            }
        }
    }
}
