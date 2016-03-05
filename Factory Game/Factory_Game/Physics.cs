using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Factory_Game
{
    /// Net force is the sum of all forces    
    ///
    public class Physics
    {

        public Vector2 objPosition;

        private static float gravity = 5.5f;
        public Physics()
        {

        }

        public Vector2 Velocity
        {
            get;
            set;
        }
        public Vector2 OldVelocity
        {
            get;
            set;
        }
        public float Friction
        {
            get;
            set;
        }
        
        public Rectangle RectangleBounds
        {
            get;
            set;
        }
        public float Mass
        {
            get;
            set;
        }

        public Vector2 position(Vector2 pos)
        {
            return pos + Velocity;
        }

        public Vector2 Acceleration(Vector2 currVelocity, Vector2 lastVelocity)    
        {
            float xAcceleration = currVelocity.X - lastVelocity.X;
            float yAcceleration = currVelocity.Y - lastVelocity.Y;
            return new Vector2(xAcceleration, yAcceleration);
                         
        }
        /// <summary>
        /// Kinetic friction is basically moving friction
        /// 
        /// </summary>
        /// <param name="friction"></param>
        /// <param name="Newtons"></param>
        /// <returns></returns>
        public float ForceOfFriction(float friction, float Newtons)
        {
            return friction * Newtons; 
        }
        /// f = ma
        /// force > forceoffriction then that object can move 
        /// 
        /// 
        /// 
        public Vector2 Force()
        {
            //    float xForce = acceleration.X * gravity;
            //    float yForce = acceleration.Y * gravity;

            

            return Vector2.Zero; 
            //return new Vector2(xForce, yForce); 
        }
        public void Update(GameTime gameTime)
        {
            objPosition = position(objPosition);

            OldVelocity = Velocity; 
        }

    }
}
