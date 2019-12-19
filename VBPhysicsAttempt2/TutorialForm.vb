Public Class TutorialForm
    Private Sub TutorialLbl1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl1.LinkClicked
        MessageBox.Show("The two types of particles that be added in the simulation are circles and rectangles. Circles can be added simply specifying the desired radius, mass and whether they are fixed or not and clicking the add circle button. If a fixed particle is added, it will not be subject to gravity and would act as an obstacle. Rectangle particles can be added by specifying their width, height and mass and by pressing the add rectangle button. Rectangle particles will always be fixed as their purpose is to be always used as obstacles, they will not be able to collide with other rectangle particles, so a group of obstacles can be created to form custom shapes.")
    End Sub
    Private Sub TutorialLbl2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl2.LinkClicked
        MessageBox.Show("If a particle is not needed anymore, it can be deleted. You can delete a particle by right-clicking any particle that when the simulation’s mode is set to ‘deleting’ which can be toggled on simply by clicking the ‘Mode’ button (second button down on the left side of the simulation).")
    End Sub
    Private Sub TutorialLbl3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl3.LinkClicked
        MessageBox.Show("If an external force is to be simulated, it can be done so by applying a force to the desired particle. Drag the cursor so it is inside a circle particle, hold down the left mouse button and drag away from the particle, in the opposite direction of the desired motion (like when playing a snooker/ pool video game) and let go of the mouse button. The magnitude of the force will depend on how far you moved your mouse away from the particle and the acceleration applied to the particle will depend on the mass of the particle, so particles that are heavier will move slower when a force is applied to them. A force can only be exerted on circle particles, as rectangle particles act as obstacles. If particles are moving fast, it is recommended to slow down or pause the simulation (explained in tutorial #4).
A particle can also be dragged manually, without the use of applying a force. This can only be done when the simulation is in ‘moving’ mode. Simply bring your cursor over a mouse particle, hold down right click to ‘grab’ the particle, drag it, and let go of right click to release the particle.
")
    End Sub
    Private Sub TutorialLbl4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl4.LinkClicked
        MessageBox.Show("The speed of the simulation can be slowed down to 20x slower than the default value of the particles are moving too fast. This can be done via the ‘Simulation speed’ slider, dragging it to the right will make the simulation slower and dragging it to the left will make the simulation faster. Furthermore, the simulation can also be paused so it can be studied in greater depth via the ‘Sim Mode’ button, which will pause the simulation if it is running or resume it if it is paused. The simulation can also be entirely reset by pressing the RESET simulation button, which will remove all particles and set all values of the simulation to the default values. 
The value of acceleration due to gravity can also be changed with the second slider. The default value is 9.8 m/s2 so particles are modelled on Earth, however, they can be modelled in space with a value of 0 m/s2 or 1.6 m/s2 if simulating the moon for example.
The Last slider sets the value of the Coefficient of restitution for all collisions (CoR). The CoR determines if the collision is elastic or not, setting it to 1 will make all the collisions completely elastic, so particles will not lose any kinetic energy, setting it to 0 will make all the collisions completely inelastic, so particles will lose all their kinetic energy.
")
    End Sub
    Private Sub TutorialLbl5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl5.LinkClicked
        MessageBox.Show("Since time is managed through a timer tick, if a particle’s velocity (change is position over time) is greater than the colliding particle’s size, it is entirely possible that particles will have the ability to pass through other particles. To prevent this, semi-implicit Euler integration has been implemented (you can read more about it in tutorial #6), however, at high velocities or high acceleration due to gravity, glitches are likely to arise. This issue is limited by the hardware, if the CPU had infinite power and the timer tick interval could go lower than 1 millisecond, there would be no problems.
Similarly, due to the reason explained above, when particles collide, the program detects the collision after the collision occurs, which means that particles, unlike in the real world, intersect. These intersections must be manually resolved by pushing the two particles apart from each other.
Furthermore, resistive forces such as friction and air resistance have been ignored as these are negligible when dealing with particles of smaller sizes. Hence, the simulation will not be entirely realistic.
")
    End Sub
    Private Sub TutorialLbl6_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TutorialLbl6.LinkClicked
        MathsForm.Show()
    End Sub

    Private Sub TutorialForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class