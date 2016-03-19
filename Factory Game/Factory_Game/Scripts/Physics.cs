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
        public Vector2 oldPosition; 
        private static float gravity = 5.5f;
        public Vector2 acceleration;
        public bool colliding; 
        public Physics()
        {
            OldVelocity = Vector2.Zero; 
        }

        public Vector2 Velocity;

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
        float terminalVelocity = 20f; 
        public Vector2 position(Vector2 pos)
        {
            Vector2 objectPosition = pos;
            objectPosition = pos;

            objectPosition.X += Velocity.X;
            // velocity
            objectPosition.Y += gravity; 
            if(Velocity.Y >= terminalVelocity)
            {
                Velocity.Y = terminalVelocity;
            }
            else if(Velocity.Y <= -terminalVelocity)
            {
                Velocity.Y = -terminalVelocity;
            }
            

            return objectPosition + Velocity;
        }
        public void Collision(float weight)
        {
            // y dir 
            float force = weight * acceleration.Y;

            if (colliding)
            {
                if (Velocity.Y <= 0)
                {
                    Velocity.Y += 1;
                    gravity = 0; 
                }
                if(0 < Velocity.Y)
                {
                    gravity = 5.5f;
                }
            }

          //  Velocity.Y = - gravity;  
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
        
        public Vector2 Force()
        {
            

            return Vector2.Zero; 
            //return new Vector2(xForce, yForce); 
        }
        public void Update(GameTime gameTime)
        {
            objPosition = position(objPosition);

            acceleration = Acceleration(Velocity, OldVelocity);
            
            OldVelocity = Velocity; 
        }

    }
}
