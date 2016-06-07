namespace ProductManager
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.buttonAddTruck = new System.Windows.Forms.Button();
            this.buttonAddBicycle = new System.Windows.Forms.Button();
            this.buttonAddMotorcycle = new System.Windows.Forms.Button();
            this.listCars = new System.Windows.Forms.ListBox();
            this.listTrucks = new System.Windows.Forms.ListBox();
            this.listBicycles = new System.Windows.Forms.ListBox();
            this.listMotorcycles = new System.Windows.Forms.ListBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxWheels = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxWheelRight = new System.Windows.Forms.CheckBox();
            this.boxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCapacity = new System.Windows.Forms.TextBox();
            this.boxTypeEngine = new System.Windows.Forms.TextBox();
            this.boxMilage = new System.Windows.Forms.TextBox();
            this.boxHorsepower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boxLoad = new System.Windows.Forms.TextBox();
            this.boxTrailors = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.boxMotorcycleType = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.boxGears = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Location = new System.Drawing.Point(13, 13);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(99, 23);
            this.buttonAddCar.TabIndex = 0;
            this.buttonAddCar.Text = "Add Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.addCar);
            // 
            // buttonAddTruck
            // 
            this.buttonAddTruck.Location = new System.Drawing.Point(118, 13);
            this.buttonAddTruck.Name = "buttonAddTruck";
            this.buttonAddTruck.Size = new System.Drawing.Size(99, 23);
            this.buttonAddTruck.TabIndex = 1;
            this.buttonAddTruck.Text = "Add Truck";
            this.buttonAddTruck.UseVisualStyleBackColor = true;
            this.buttonAddTruck.Click += new System.EventHandler(this.addTruck);
            // 
            // buttonAddBicycle
            // 
            this.buttonAddBicycle.Location = new System.Drawing.Point(223, 13);
            this.buttonAddBicycle.Name = "buttonAddBicycle";
            this.buttonAddBicycle.Size = new System.Drawing.Size(99, 23);
            this.buttonAddBicycle.TabIndex = 2;
            this.buttonAddBicycle.Text = "Add Bicycle";
            this.buttonAddBicycle.UseVisualStyleBackColor = true;
            this.buttonAddBicycle.Click += new System.EventHandler(this.addBicycle);
            // 
            // buttonAddMotorcycle
            // 
            this.buttonAddMotorcycle.Location = new System.Drawing.Point(328, 12);
            this.buttonAddMotorcycle.Name = "buttonAddMotorcycle";
            this.buttonAddMotorcycle.Size = new System.Drawing.Size(99, 23);
            this.buttonAddMotorcycle.TabIndex = 3;
            this.buttonAddMotorcycle.Text = "Add Motorcycle";
            this.buttonAddMotorcycle.UseVisualStyleBackColor = true;
            this.buttonAddMotorcycle.Click += new System.EventHandler(this.addMotorcycle);
            // 
            // listCars
            // 
            this.listCars.FormattingEnabled = true;
            this.listCars.Location = new System.Drawing.Point(434, 13);
            this.listCars.Name = "listCars";
            this.listCars.Size = new System.Drawing.Size(135, 420);
            this.listCars.TabIndex = 4;
            this.listCars.SelectedIndexChanged += new System.EventHandler(this.listCars_SelectedIndexChanged);
            // 
            // listTrucks
            // 
            this.listTrucks.FormattingEnabled = true;
            this.listTrucks.Location = new System.Drawing.Point(575, 14);
            this.listTrucks.Name = "listTrucks";
            this.listTrucks.Size = new System.Drawing.Size(135, 420);
            this.listTrucks.TabIndex = 5;
            this.listTrucks.SelectedIndexChanged += new System.EventHandler(this.listTrucks_SelectedIndexChanged);
            // 
            // listBicycles
            // 
            this.listBicycles.FormattingEnabled = true;
            this.listBicycles.Location = new System.Drawing.Point(716, 14);
            this.listBicycles.Name = "listBicycles";
            this.listBicycles.Size = new System.Drawing.Size(135, 420);
            this.listBicycles.TabIndex = 6;
            this.listBicycles.SelectedIndexChanged += new System.EventHandler(this.listBicycles_SelectedIndexChanged);
            // 
            // listMotorcycles
            // 
            this.listMotorcycles.FormattingEnabled = true;
            this.listMotorcycles.Location = new System.Drawing.Point(857, 14);
            this.listMotorcycles.Name = "listMotorcycles";
            this.listMotorcycles.Size = new System.Drawing.Size(135, 420);
            this.listMotorcycles.TabIndex = 7;
            this.listMotorcycles.SelectedIndexChanged += new System.EventHandler(this.listMotorcycles_SelectedIndexChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(998, 14);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(136, 22);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.write);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(998, 42);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(136, 22);
            this.buttonLoad.TabIndex = 9;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "name:";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(100, 136);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(100, 20);
            this.boxName.TabIndex = 11;
            // 
            // boxWheels
            // 
            this.boxWheels.Location = new System.Drawing.Point(100, 84);
            this.boxWheels.Name = "boxWheels";
            this.boxWheels.Size = new System.Drawing.Size(100, 20);
            this.boxWheels.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "no_wheels:";
            // 
            // boxWheelRight
            // 
            this.boxWheelRight.AutoSize = true;
            this.boxWheelRight.Location = new System.Drawing.Point(100, 61);
            this.boxWheelRight.Name = "boxWheelRight";
            this.boxWheelRight.Size = new System.Drawing.Size(67, 17);
            this.boxWheelRight.TabIndex = 15;
            this.boxWheelRight.Text = "rightSide";
            this.boxWheelRight.UseVisualStyleBackColor = true;
            // 
            // boxPrice
            // 
            this.boxPrice.Location = new System.Drawing.Point(100, 110);
            this.boxPrice.Name = "boxPrice";
            this.boxPrice.Size = new System.Drawing.Size(100, 20);
            this.boxPrice.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "price:";
            // 
            // boxCapacity
            // 
            this.boxCapacity.Location = new System.Drawing.Point(98, 186);
            this.boxCapacity.Name = "boxCapacity";
            this.boxCapacity.Size = new System.Drawing.Size(100, 20);
            this.boxCapacity.TabIndex = 18;
            // 
            // boxTypeEngine
            // 
            this.boxTypeEngine.Location = new System.Drawing.Point(98, 264);
            this.boxTypeEngine.Name = "boxTypeEngine";
            this.boxTypeEngine.Size = new System.Drawing.Size(100, 20);
            this.boxTypeEngine.TabIndex = 19;
            // 
            // boxMilage
            // 
            this.boxMilage.Location = new System.Drawing.Point(98, 238);
            this.boxMilage.Name = "boxMilage";
            this.boxMilage.Size = new System.Drawing.Size(100, 20);
            this.boxMilage.TabIndex = 20;
            // 
            // boxHorsepower
            // 
            this.boxHorsepower.Location = new System.Drawing.Point(98, 212);
            this.boxHorsepower.Name = "boxHorsepower";
            this.boxHorsepower.Size = new System.Drawing.Size(100, 20);
            this.boxHorsepower.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "capacity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "horsepower:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "milage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "type:";
            // 
            // boxLoad
            // 
            this.boxLoad.Location = new System.Drawing.Point(99, 317);
            this.boxLoad.Name = "boxLoad";
            this.boxLoad.Size = new System.Drawing.Size(100, 20);
            this.boxLoad.TabIndex = 27;
            // 
            // boxTrailors
            // 
            this.boxTrailors.Location = new System.Drawing.Point(99, 344);
            this.boxTrailors.Name = "boxTrailors";
            this.boxTrailors.Size = new System.Drawing.Size(100, 20);
            this.boxTrailors.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "max load:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 350);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "trailors:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "motorcycle type:";
            // 
            // boxMotorcycleType
            // 
            this.boxMotorcycleType.Location = new System.Drawing.Point(100, 395);
            this.boxMotorcycleType.Name = "boxMotorcycleType";
            this.boxMotorcycleType.Size = new System.Drawing.Size(100, 20);
            this.boxMotorcycleType.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(9, 368);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 33;
            this.label12.Text = "Motorcycle:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(11, 290);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 24);
            this.label13.TabIndex = 34;
            this.label13.Text = "Truck:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(11, 159);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 24);
            this.label14.TabIndex = 35;
            this.label14.Text = "Engine info:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(9, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 36;
            this.label8.Text = "Basic:";
            // 
            // boxGears
            // 
            this.boxGears.Location = new System.Drawing.Point(327, 395);
            this.boxGears.Name = "boxGears";
            this.boxGears.Size = new System.Drawing.Size(100, 20);
            this.boxGears.TabIndex = 38;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "bike gears:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(236, 368);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 24);
            this.label16.TabIndex = 39;
            this.label16.Text = "Bike:";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 439);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.boxGears);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.boxMotorcycleType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxTrailors);
            this.Controls.Add(this.boxLoad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.boxHorsepower);
            this.Controls.Add(this.boxMilage);
            this.Controls.Add(this.boxTypeEngine);
            this.Controls.Add(this.boxCapacity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxPrice);
            this.Controls.Add(this.boxWheelRight);
            this.Controls.Add(this.boxWheels);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.listMotorcycles);
            this.Controls.Add(this.listBicycles);
            this.Controls.Add(this.listTrucks);
            this.Controls.Add(this.listCars);
            this.Controls.Add(this.buttonAddMotorcycle);
            this.Controls.Add(this.buttonAddBicycle);
            this.Controls.Add(this.buttonAddTruck);
            this.Controls.Add(this.buttonAddCar);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Button buttonAddTruck;
        private System.Windows.Forms.Button buttonAddBicycle;
        private System.Windows.Forms.Button buttonAddMotorcycle;
        private System.Windows.Forms.ListBox listCars;
        private System.Windows.Forms.ListBox listTrucks;
        private System.Windows.Forms.ListBox listBicycles;
        private System.Windows.Forms.ListBox listMotorcycles;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxWheels;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox boxWheelRight;
        private System.Windows.Forms.TextBox boxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxCapacity;
        private System.Windows.Forms.TextBox boxTypeEngine;
        private System.Windows.Forms.TextBox boxMilage;
        private System.Windows.Forms.TextBox boxHorsepower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox boxLoad;
        private System.Windows.Forms.TextBox boxTrailors;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox boxMotorcycleType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxGears;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}

