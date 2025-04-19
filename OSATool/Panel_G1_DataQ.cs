using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace OSATool
{
    public partial class Panel_G1_DataQ : UserControl
    {
        Excel.Workbook wb = Globals.OSATool.Application.ActiveWorkbook;
        Excel.Range rng = null;

        public Panel_G1_DataQ()
        {
            InitializeComponent();

            UpdateList();
            if (this.lvw_Variables.Items.Count > 0)
            {
                this.txt_VarName.Text = this.lvw_Variables.Items[0].SubItems[0].Text;
                this.txt_VarGroup.Text = this.lvw_Variables.Items[0].SubItems[1].Text;
                this.txt_VarDefine.Text = this.lvw_Variables.Items[0].SubItems[2].Text;
            }

        }

        private void UpdateList()
        {
            this.lvw_Variables.Items.Clear();

            addlistitem(this.lvw_Variables, "Case", "all", "Member name index");
            addlistitem(this.lvw_Variables, "Type", "", "Type of calculation template");
            addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Member", "all", "Member name index");
            if (GlobalVar.Tools_Footing) addlistitem(this.lvw_Variables, "Point", "p", "Point name index");
            if (GlobalVar.Tools_Beam) addlistitem(this.lvw_Variables, "Beam", "b", "Beam name index");
            if (GlobalVar.Tools_Column) addlistitem(this.lvw_Variables, "Column", "c", "Column name index");
            if (GlobalVar.Tools_Slab) addlistitem(this.lvw_Variables, "Slab", "s", "Slab name index");
            if (GlobalVar.Tools_Wall) addlistitem(this.lvw_Variables, "Wall", "w", "Wall name index");
            if (GlobalVar.Tools_Wall) addlistitem(this.lvw_Variables, "Pier", "w", "Slab name index");
            if (GlobalVar.Tools_Wall) addlistitem(this.lvw_Variables, "Spandrel", "w", "Slab name index");
            if (GlobalVar.Tools_Shell) addlistitem(this.lvw_Variables, "Shell", "se", "Slab name index");

            addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Group", "", "Group name index");
            addlistitem(this.lvw_Variables, "Story", "", "Story name index");
            addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Section", "p6,p7,b5,b6,c5,c6,w7,w8,s7,s8", "Member cross-section");
            addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Span", "b5", "Length of beam");
            addlistitem(this.lvw_Variables, "Length", "b5,c5", "Length of beam/column");
            addlistitem(this.lvw_Variables, "Height", "b5,c5", "Height of Column");
            addlistitem(this.lvw_Variables, "Thick", "w5,w6,se5,se6", "Thickness of wall/shell section");
            addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
            addlistitem(this.lvw_Variables, "Width", "p6,p7,b5,c5", "Width of a rectangular section");
            addlistitem(this.lvw_Variables, "Depth", "p6,p7,b5,c5", "Depth of a rectangular section");
            addlistitem(this.lvw_Variables, "Dia", "p6,p7", "Diameter of a circular section");

            if (GlobalVar.Tools_Analysis)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "Mconc", "p6,p7", "Section: Material of concrete");
                addlistitem(this.lvw_Variables, "MsteelM", "p6,p7", "Section: Material of main bar");
                addlistitem(this.lvw_Variables, "MsteelS", "p6,p7", "Section: Material of shear bar");
                addlistitem(this.lvw_Variables, "Pattern", "p6,p7", "Section parameters");
                addlistitem(this.lvw_Variables, "Linktype", "p6,p7", "Section parameters");
                addlistitem(this.lvw_Variables, "Cover", "p6,p7", "Section parameters");
                addlistitem(this.lvw_Variables, "N3bar", "p6,p7", "Section: Number of long. bar along 3-dir face");
                addlistitem(this.lvw_Variables, "N2bar", "p6,p7", "Section: Number of long. bar along 2-dir face");
                addlistitem(this.lvw_Variables, "Ncbar", "p6,p7", "Section: Number of long. bar in circle");
                addlistitem(this.lvw_Variables, "Barsize", "p6,p7", "Section: Long bar diameter");
                addlistitem(this.lvw_Variables, "N3link", "p6,p7", "Section: Number of shear leg in 3-dir");
                addlistitem(this.lvw_Variables, "N2link", "p6,p7", "Section: Number of shear leg in 2-dir");
                addlistitem(this.lvw_Variables, "Linkspace", "p6,p7", "Section: Spacing of shear link");
                addlistitem(this.lvw_Variables, "Linksize", "p6,p7", "Section: Diameter of shear link");
                addlistitem(this.lvw_Variables, "Design", "p6,p7", "Section: Design (True) Check (False)");
            }


            if (GlobalVar.Tools_Beam || GlobalVar.Tools_Column)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "KMajor", "c7,c8", "Major unbraced length ratio");
                addlistitem(this.lvw_Variables, "KMinor", "c7,c8", "Minor unbraced length ratio");
                addlistitem(this.lvw_Variables, "KTB", "c7,c8", "Torsion buckling unbraced length ratio");
                addlistitem(this.lvw_Variables, "LMajor", "c7,c8", "Major unbraced length");
                addlistitem(this.lvw_Variables, "LMinor", "c7,c8", "Minor unbraced length");
                addlistitem(this.lvw_Variables, "LTB", "c7,c8", "Torsion buckling unbraced length");
            }

            if (GlobalVar.Tools_Miscs)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", " - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Dead.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.SuperDead.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Live.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.ReduceLive.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Rooflive.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Notional.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Quake.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.QuakeDrift.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Wind.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Snow.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Construction.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Prestress.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.PrestressTransfer.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, ETABSv1.eLoadPatternType.Other.ToString(), "l1,l2", "Load Pattern");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "LoadCase", "l3,l4", "List of load cases");
                addlistitem(this.lvw_Variables, "LoadCombo", "l5~l8", "List of load combinations");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "FX", "f11,f12,f13", "Global applied point/distributed load in X-Direction");
                addlistitem(this.lvw_Variables, "FY", "f11,f12,f13", "Global applied point/distributed load in Y-Direction");
                addlistitem(this.lvw_Variables, "FZ", "f11,f12,f13", "Global applied point/distributed load in Z-Direction");
                addlistitem(this.lvw_Variables, "MX", "f11,f12,f13", "Global applied point/distributed load in X-Direction");
                addlistitem(this.lvw_Variables, "MY", "f11,f12,f13", "Global applied point/distributed load in Y-Direction");
                addlistitem(this.lvw_Variables, "MZ", "f11,f12,f13", "Global applied point/distributed load in Z-Direction");
                addlistitem(this.lvw_Variables, "F1", "f11,f12,f13", "Local applied point/distributed load in 1-Direction");
                addlistitem(this.lvw_Variables, "F2", "f11,f12,f13", "Local applied point/distributed load in 2-Direction");
                addlistitem(this.lvw_Variables, "F3", "f11,f12,f13", "Local applied point/distributed load in 3-Direction");
                addlistitem(this.lvw_Variables, "M1", "f11,f12,f13", "Local applied point/distributed load in 1-Direction");
                addlistitem(this.lvw_Variables, "M2", "f11,f12,f13", "Local applied point/distributed load in 2-Direction");
                addlistitem(this.lvw_Variables, "M3", "f11,f12,f13", "Local applied point/distributed load in 3-Direction");
            }


            if (GlobalVar.Tools_Footing)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "XCoord", "f5,f6", "X Coordinate of the Point center");
                addlistitem(this.lvw_Variables, "YCoord", "f5,f6", "Y Coordinate of the Point center");
                addlistitem(this.lvw_Variables, "ZCoord", "f5,f6", "Z Coordinate of the Point center");
                //addlistitem(this.lvw_Variables, "Nspan", "", "Number of span of Beam/Column/Strip");
                //addlistitem(this.lvw_Variables, "Ne", "", "Number of element in one group name");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "Restraint", "f5,f6", "Restraint property of point");
                addlistitem(this.lvw_Variables, "N-N-N-N-N-N", "f6", "No Restraint");
                addlistitem(this.lvw_Variables, "Y-Y-Y-N-N-N", "f6", "Pin Restraint");
                addlistitem(this.lvw_Variables, "Y-Y-Y-Y-Y-Y", "f6", "Fixed Restraint");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "PSpring", "f5,f6", "Spring property of point");
                addlistitem(this.lvw_Variables, "LSpring", "b5,b6", "Spring property of frame");
                addlistitem(this.lvw_Variables, "ASpring", "se5,se6", "Spring property of area");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "KsFx", "p8,p9", "Spring stiffness for Fx");
                addlistitem(this.lvw_Variables, "KsFy", "p8,p9", "Spring stiffness for Fy");
                addlistitem(this.lvw_Variables, "KsFz", "p8,p9", "Spring stiffness for Fx");
                addlistitem(this.lvw_Variables, "KsMx", "p8,p9", "Spring stiffness for Mx");
                addlistitem(this.lvw_Variables, "KsMy", "p8,p9", "Spring stiffness for My");
                addlistitem(this.lvw_Variables, "KsMz", "p8,p9", "Spring stiffness for Mz");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "Fxmax", "f12", "Maximum axial force of Point reaction along X-dir");
                addlistitem(this.lvw_Variables, "Fxmin", "f12", "Minimum axial force of Point reaction along X-dir");
                addlistitem(this.lvw_Variables, "Fymax", "f12", "Maximum axial force of Point reaction along Y-dir");
                addlistitem(this.lvw_Variables, "Fymin", "f12", "Minimum axial force of Point reaction along Y-dir");
                addlistitem(this.lvw_Variables, "Fzmax", "f12", "Maximum axial force of Point reaction along Z-dir");
                addlistitem(this.lvw_Variables, "Fzmin", "f12", "Minimum axial force of Point reaction along Z-dir");
                addlistitem(this.lvw_Variables, "Mxmax", "f12", "Maximum moment of Point reaction about X-dir");
                addlistitem(this.lvw_Variables, "Mxmin", "f12", "Minimum moment of Point reaction about X-dir");
                addlistitem(this.lvw_Variables, "Mymax", "f12", "Maximum moment of Point reaction about Y-dir");
                addlistitem(this.lvw_Variables, "Mymin", "f12", "Minimum moment of Point reaction about Y-dir");
                addlistitem(this.lvw_Variables, "Mzmax", "f12", "Maximum moment of Point reaction about Z-dir");
                addlistitem(this.lvw_Variables, "Mzmin", "f12", "Minimum moment of Point reaction about Z-dir");
            }

            if (GlobalVar.Tools_Beam || GlobalVar.Tools_Column)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "Pmax", "c13,c14,w11,w12,b12,b13", "Maximum axial force of beam/column/wall");
                addlistitem(this.lvw_Variables, "Pmin", "c13,c14,w11,w12,b12,b13", "Minimum axial force of beam/column/wall");
                addlistitem(this.lvw_Variables, "Tmax", "c13,c14,w11,w12,b12,b13", "Maximum torsion force of beam/column/wall");
                addlistitem(this.lvw_Variables, "V2max", "c13,c14,w11,w12,b12,b13", "Maximum shear force beam/column/wall in 2-direction");
                addlistitem(this.lvw_Variables, "V3max", "c13,c14,w11,w12,b12,b13", "Maximum shear force beam/column/wall in 3-direction");
                addlistitem(this.lvw_Variables, "M3max", "c13,c14,w11,w12,b12,b13", "Maximum moment force beam/column/wall in 3-direction");
                addlistitem(this.lvw_Variables, "M2max", "c13,c14,w11,w12,b12,b13", "Maximum moment force beam/column/wall in 2-direction");
            }

            if (GlobalVar.Tools_Column || GlobalVar.Tools_Wall)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "M3Tmax", "c13,c14,w11,w12,b12,b13", "Maximum moment at top column/pier in 3-direction");
                addlistitem(this.lvw_Variables, "M3Bmax", "c13,c14,w11,w12,b12,b13", "Maximum moment at bottom column/pier in 3-direction");
                addlistitem(this.lvw_Variables, "M2Tmax", "c13,c14,w11,w12,b12,b13", "Maximum moment at top column/pier in 2-direction");
                addlistitem(this.lvw_Variables, "M2Bmax", "c13,c14,w11,w12,b12,b13", "Maximum moment at bottom column/pier in 2-direction");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "M3Lmax", "w11,w12", "Maximum moment at left spandrel in 3-direction");
                addlistitem(this.lvw_Variables, "M3Rmax", "w11,w12", "Maximum moment at right spandrel in 3-direction");
                addlistitem(this.lvw_Variables, "M2Lmax", "w11,w12", "Maximum moment at left spandrel in 2-direction");
                addlistitem(this.lvw_Variables, "M2Rmax", "w11,w12", "Maximum moment at right spandrel in 2-direction");
            }

            if (GlobalVar.Tools_Beam || GlobalVar.Tools_Slab)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "MtL", "b12,b13", "Maximum top moment at the left-end of beam/slab");
                addlistitem(this.lvw_Variables, "MtM", "b12,b13", "Maximum top moment at the middle of beam/slab");
                addlistitem(this.lvw_Variables, "MtR", "b12,b13", "Maximum top moment at the right-end of beam/slab");
                addlistitem(this.lvw_Variables, "MbL", "b12,b13", "Maximum bottom moment at the left-end of beam/slab");
                addlistitem(this.lvw_Variables, "MbM", "b12,b13", "Maximum bottom moment at the middle of beam/slab");
                addlistitem(this.lvw_Variables, "MbR", "b12,b13", "Maximum bottom moment at the right-end of beam/slab");
                addlistitem(this.lvw_Variables, "VL", "b12,b13", "Maximum shear force at the left-end of beam/slab");
                addlistitem(this.lvw_Variables, "VM", "b12,b13", "Maximum shear force at the middle of beam/slab");
                addlistitem(this.lvw_Variables, "VR", "b12,b13", "Maximum shear force at the right-end of beam/slab");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "MtL_i", "b15", "Maximum top moment at the left-end of beam for Comb i");
                addlistitem(this.lvw_Variables, "MtM_i", "b15", "Maximum top moment at the middle of beam for Comb i");
                addlistitem(this.lvw_Variables, "MtR_i", "b15", "Maximum top moment at the right-end of beam Comb i");
                addlistitem(this.lvw_Variables, "MbL_i", "b15", "Maximum bottom moment at the left-end of beam for Comb i");
                addlistitem(this.lvw_Variables, "MbM_i", "b15", "Maximum bottom moment at the middle of beam for Comb i");
                addlistitem(this.lvw_Variables, "MbR_i", "b15", "Maximum bottom moment at the right-end of beam for Comb i");
                addlistitem(this.lvw_Variables, "VL_i", "b15", "Maximum shear force at the left-end of beam for Comb i");
                addlistitem(this.lvw_Variables, "VM_i", "b15", "Maximum shear force at the middle of beam for Comb i");
                addlistitem(this.lvw_Variables, "VR_i", "b15", "Maximum shear force at the right-end of beam for Comb i");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "Dmid_i", "b16", "Maximum deflection at the middle of beam for Comb i");
                addlistitem(this.lvw_Variables, "Dend_i", "b16", "Diifferential deflection between the ends of beam for Comb i");
            }
                

            if (GlobalVar.Tools_Slab)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "SPmax", "s6", "Maximum axial force of slab strip");
                addlistitem(this.lvw_Variables, "SPmin", "s6", "Minimum axial force of slab strip");
                addlistitem(this.lvw_Variables, "SMtmax", "s6", "Maximum top moment of slab strip");
                addlistitem(this.lvw_Variables, "SMbmax", "s6", "Maximum bottom moment of slab strip");
                addlistitem(this.lvw_Variables, "SVmax", "s6", "Maximum shear force of slab strip");
            }


            if (GlobalVar.Tools_Shell)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "F11max", "se6", "Maximum in-plane normal force per unit length of shell");
                addlistitem(this.lvw_Variables, "F11min", "se6", "Maximum in-plane normal force per unit length of shell");
                addlistitem(this.lvw_Variables, "F22max", "se6", "Maximum in-plane normal force per unit length of shell");
                addlistitem(this.lvw_Variables, "F22min", "se6", "Maximum in-plane normal force per unit length of shell");
                addlistitem(this.lvw_Variables, "F12max", "se6", "Maximum in-plane shear force per unit length of shell");
                addlistitem(this.lvw_Variables, "M11max", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "M11min", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "M22max", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "M22min", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "M12max", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "M12min", "se6", "Maximum out-of-plane moment per unit length of shell");
                addlistitem(this.lvw_Variables, "V13max", "se6", "Maximum out-of-plane shear force per unit length of shell");
                addlistitem(this.lvw_Variables, "V23max", "se6", "Maximum out-of-plane shear force per unit length of shell");
            }


            if (GlobalVar.Tools_Beam || GlobalVar.Tools_Slab)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "MtL_Asd", "b14", "Required Top reinforcement area at the begin of beam/slab");
                addlistitem(this.lvw_Variables, "MtM_Asd", "b14", "Required Top reinforcement area at the middle of beam/slab");
                addlistitem(this.lvw_Variables, "MtR_Asd", "b14", "Required Top reinforcement area at the end of beam/slab");
                addlistitem(this.lvw_Variables, "MbL_Asd", "b14", "Required Bottom reinforcement areaat the begin of beam/slab");
                addlistitem(this.lvw_Variables, "MbM_Asd", "b14", "Required Bottom reinforcement areaat the middle of beam/slab");
                addlistitem(this.lvw_Variables, "MbR_Asd", "b14", "Required Bottom reinforcement areaat the end of beam/slab");
                addlistitem(this.lvw_Variables, "VL_Asd", "b14", "Required Shear reinforcement area at the begin of beam/slab");
                addlistitem(this.lvw_Variables, "VM_Asd", "b14", "Required Shear reinforcement areaat the middle of beam/slab");
                addlistitem(this.lvw_Variables, "VR_Asd", "b14", "Required Shear reinforcement areaat the end of beam/slab");
            }


            if (GlobalVar.Tools_Column || GlobalVar.Tools_Wall)
            {
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "PMM_Asd", "c15,w13", "Required longitudinal reinforcement area of column/wall/pier");
                addlistitem(this.lvw_Variables, "PMM_UR", "c15,w13", "Flexural utilization factor of column/wall/pier");
                addlistitem(this.lvw_Variables, "Link1_Asd", "c15,w13", "Required shear reinforcement area in major-direction of column/wall/pier");
                addlistitem(this.lvw_Variables, "Link2_Asd", "c15,w13", "Required shear reinforcement area in minor-direction column/wall/pier");
                addlistitem(this.lvw_Variables, "- - - - - - -", "- - - -", "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -");
                addlistitem(this.lvw_Variables, "MTop_Asd", "c15,w13", "Required top reinforcement area of spandrel");
                addlistitem(this.lvw_Variables, "MBot_Asd", "c15,w13", "Required bot reinforcement area of spandrel");
                addlistitem(this.lvw_Variables, "LinkH_Asd", "c15,w13", "Required horizontal shear reinforcement area of spandrel");
                addlistitem(this.lvw_Variables, "LinkV_Asd", "c15,w13", "Required vertical shear reinforcement area of spandrel");
            }

        }

        void addlistitem(ListView mainlistview, string itemname, string itemgroup, string itemmeaning)
        {
            ListViewItem newList = new ListViewItem(itemname);
            newList.SubItems.Add(itemgroup);
            newList.SubItems.Add(itemmeaning);
            this.lvw_Variables.Items.Add(newList);
            return;
        }

        private void Bt_Assign_Click(object sender, EventArgs e)
        {

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Int32 colindex = 1;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (!this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("- - - -"))
                    { 
                        rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, colindex].Font.Color = Color.Blue;
                        colindex++;
                    }
                }

            }


            //if (this.txt_VarName.Text != null)
            //{

            //    if ((this.txt_VarName.Text.Length > 1) & (this.txt_VarName.Text.Substring(0, 1) == "_"))
            //    {
            //        rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;
            //        rng.Cells[1, 1].Value = this.txt_VarName.Text.Substring(1, this.txt_VarName.Text.Length - 1);
            //    }
            //    else
            //    {
            //        rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;
            //        rng.Cells[1, 1].Value = this.txt_VarName.Text;
            //    }
            //}
        }

        private void lvw_Variables_Click(object sender, EventArgs e)
        {
            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                if (!this.lvw_Variables.SelectedItems[0].SubItems[0].Text.Contains("- - - -"))
                {
                    this.txt_VarName.Text = this.lvw_Variables.SelectedItems[0].SubItems[0].Text;
                    this.txt_VarGroup.Text = this.lvw_Variables.SelectedItems[0].SubItems[1].Text;
                    this.txt_VarDefine.Text = this.lvw_Variables.SelectedItems[0].SubItems[2].Text;
                }
                else
                {
                    this.txt_VarName.Text = "";
                    this.txt_VarGroup.Text = "";
                    this.txt_VarDefine.Text = "";
                }
            }
        }

        private void Bt_KLSIndexRange_Click(object sender, EventArgs e)
        {
            Form_Local_Input1 frm = new Form_Local_Input1("KLSIndexRange");
            frm.Show();//.ShowDialog();
        }

        private void Bt_SetOutputFactors_Click(object sender, EventArgs e)
        {
            Form_OutputFactor frm = new Form_OutputFactor();
            frm.Show();//.ShowDialog();
        }

        private void Bt_SetComboOutputRange_Click(object sender, EventArgs e)
        {
            Form_Global_Input1 frm = new Form_Global_Input1("ComboOutputRange");
            frm.Show();//.ShowDialog();
        }

        private void lvw_Variables_DoubleClick(object sender, EventArgs e)
        {

            if (this.lvw_Variables.SelectedItems.Count > 0)
            {
                rng = Globals.OSATool.Application.ActiveWindow.RangeSelection;

                Int32 colindex = 1;

                for (Int32 i = 0; i < this.lvw_Variables.SelectedItems.Count; i++)
                {

                    if (!this.lvw_Variables.SelectedItems[i].SubItems[0].Text.Contains("- - - -"))
                    {
                        rng.Cells[1, colindex].Value = this.lvw_Variables.SelectedItems[i].SubItems[0].Text;
                        rng.Cells[1, colindex].Font.Color = Color.Blue;
                        colindex++;
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_DataSetting frm = new Form_DataSetting();
            frm.ShowDialog();
        }

        private void commandsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Commands frm = new Form_Commands();
            frm.ShowDialog();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateList();
        }
    }




}
