<template>
   <section class="menu" id="menu">

<h1 class="heading"> Reservar <span>Asientos</span> </h1>


  <section id="section">
    <div class="container">
      <!-- leftCont -->
      <div class="leftCont">
        <div class="leftMainCont">
          <div class="legendContainer">
            <ul>
              <li>
                <div class="seat legend"></div>
                <small>Disponible</small>
              </li>
              <li>
                <div class="seat legend selected"></div>
                <small>Seleccionado</small>
              </li>
              <li>
                <div class="seat legend occupied"></div>
                <small>Ocupado</small>
              </li>
            </ul>
          </div>
          <!-- seat Container -->
          <div class="mainSeatCont">
            <div class="screen">
              <small>Escenario</small>
            </div>
            <div class="seatCont" id="seatCont">
              <div class="seatRowCont1 seatRowCont">
                <div class="row">
                  <div class="seat" id="1"></div>
                  <div class="seat" id="2"></div>
                  <div class="seat" id="3"></div>
                  <div class="seat" id="4"></div>
                  <div class="seat" id="5"></div>
                  <div class="seat" id="6"></div>
                  <div class="seat" id="7"></div>
                  <div class="seat" id="8"></div>
                </div>
                <div class="row">
                  <div class="seat" id="9"></div>
                  <div class="seat" id="10"></div>
                  <div class="seat" id="11"></div>
                  <div class="seat" id="12"></div>
                  <div class="seat" id="13"></div>
                  <div class="seat" id="14"></div>
                  <div class="seat" id="16"></div>
                  <div class="seat" id="16"></div>
                </div>
              </div>
              <div class="seatRowCont2 seatRowCont">
                <div class="row">
                  <div class="seat" id="17"></div>
                  <div class="seat" id="18"></div>
                  <div class="seat" id="19"></div>
                  <div class="seat" id="20"></div>
                  <div class="seat" id="21"></div>
                  <div class="seat" id="22"></div>
                  <div class="seat" id="23"></div>
                  <div class="seat" id="24"></div>
                </div>
                <div class="row">
                  <div class="seat" id="25"></div>
                  <div class="seat" id="26"></div>
                  <div class="seat" id="27"></div>
                  <div class="seat" id="28"></div>
                  <div class="seat" id="29"></div>
                  <div class="seat" id="30"></div>
                  <div class="seat" id="31"></div>
                  <div class="seat" id="32"></div>
                </div>
                <div class="row">
                  <div class="seat" id="33"></div>
                  <div class="seat" id="34"></div>
                  <div class="seat" id="35"></div>
                  <div class="seat" id="36"></div>
                  <div class="seat" id="37"></div>
                  <div class="seat" id="38"></div>
                  <div class="seat" id="39"></div>
                  <div class="seat" id="40"></div>
                </div>
                <div class="row">
                  <div class="seat" id="41"></div>
                  <div class="seat" id="42"></div>
                  <div class="seat" id="43"></div>
                  <div class="seat" id="44"></div>
                  <div class="seat" id="45"></div>
                  <div class="seat" id="46"></div>
                  <div class="seat" id="47"></div>
                  <div class="seat" id="48"></div>
                </div>
              </div>
              <div class="seatRowCont3 seatRowCont">
                <div class="row">
                  <div class="seat" id="1"></div>
                  <div class="seat" id="2"></div>
                  <div class="seat" id="1"></div>
                  <div class="seat" id="2"></div>
                  <div class="seat" id="1"></div>
                  <div class="seat" id="2"></div>
                  <div class="seat" id="1"></div>
                  <div class="seat" id="2"></div>
                </div>
                <div class="row">
                  <div class="seat" id="49"></div>
                  <div class="seat" id="50"></div>
                  <div class="seat" id="51"></div>
                  <div class="seat" id="52"></div>
                  <div class="seat" id="53"></div>
                  <div class="seat" id="54"></div>
                  <div class="seat" id="55"></div>
                  <div class="seat" id="56"></div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
      <!-- Right Cont -->
      <div class="rightCont">
        <div class="confirmCont">
          <div class="rightTopCont">
            <!-- moviename -->

            <div class="movieInfo">
              <!--<div class="selectMovie">
                <label>
                  <p>Select Your Movie</p>
                  <select id="selectMovie"></select>
                </label>
              </div>-->
              <div class="movieName">
                <p>Nombre Obra</p>
                <h1 id="movieName"> </h1>
              </div>
              <div class="moviePrice">
                <p>Precio obra</p>
                <h1 id="moviePrice"> </h1>
              </div>
              <div class="dateCont">
                <p>Fecha</p>
                <p id="dateOn" class="dateOn"> </p>

              </div>
            </div>
          </div>
          <div class="rightBottomCont">
            <div class="selectedSeatCont">
              <p>ASIENTOS SELECCIONADOS</p>
              <div class="selectedSeatsHolder" id="selectedSeatsHolder">
                <span class="noSelected">No Seat Selected</span>
              </div>
            </div>
            <!-- Seat number and price -->

            <div class="numberOfSeatsCont">
              <div class="numberOfSeatEl">
                <p><span id="numberOfSeat">0</span> Seats(s)</p>
              </div>
              <div class="priceCont">
                <p id="totalPrice">$ 0</p>
              </div>
            </div>
            <!-- button Cont -->

            <div class="buttonCont">
              <div class="cancelBtn">
                <button id="cancelBtn">Cancelar</button>
              </div>
              <div class="proceedBtnEl">
                <!--<button href="Compra.html?id=placeholder" id="proceedBtn">Continuar</button>-->
                <RouterLink to="/compra" class="btn" id="proceedBtn">Continuar</RouterLink>
                </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
</section>
</template>
  
  
<script setup lang="ts">

</script>
  
  
<style scoped>
/*  */
/* Success Modal */
/* Desktop */
@keyframes modalAnimation {
  0% {
    margin-top: -5px;
  }
  100% {
    margin-top: 0px;
  }
}
* {
  padding: 0%;
  margin: 0%;
  box-sizing: border-box;
  font-family: sans-serif;
}

.leftCont {
  width: 100%;
  background-color: #f1f1f1;
}

.leftMainCont {
  width: 100%;
}

body {
  background-color: #f1f1f1;
}

.container .legendContainer {
  background-color: #f1f1f1;
  display: flex;
  padding: 1rem;
  width: 100%;
}
.container .legendContainer ul {
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: space-evenly;
  list-style: none;
  max-width: 600px;
  margin: 0 auto;
  user-select: none;
}
.container .legendContainer ul li {
  display: flex;
  align-items: center;
  justify-content: center;
}
.container .legendContainer ul li small {
  color: #bdbdbd;
  font-size: 12px;
  letter-spacing: 1px;
  margin-bottom: 4px;
}
.container .legendContainer .seat {
  cursor: default;
  margin-bottom: 10px;
}
.container .legendContainer .seat:hover {
  background-color: #fff;
}
.container .legendContainer .seat:hover::after {
  background-color: #fff;
}
.container .leftMainCont .seat {
  height: 25px;
  width: 30px;
  border: 1px solid #30C2C1;
  border-radius: 2px 2px 4px 4px;
  margin: 10px;
  margin-bottom: 0.8rem;
  position: relative;
  cursor: pointer;
  background-color: #32FBFF;
  transition: 0.3s ease background-color;
}
.container .leftMainCont .seat::after {
  content: "";
  height: 23px;
  width: 20px;
  border: 1px solid #30C2C1;
  position: absolute;
  left: 50%;
  top: 29%;
  transform: translate(-50%, -50%);
  background-color: #32FBFF;
  border-radius: 2px 2px;
  transition: 0.3s ease background-color;
}
.container .leftMainCont .seat:hover {
  background-color: #e6e6e6;
}
.container .leftMainCont .seat:hover::after {
  background-color: #e6e6e6;
}
.container .leftMainCont .seat.occupied {
  background-color: #FF3632;
  border: 1px solid #C23031;
}
.container .leftMainCont .seat.occupied::after {
  background-color: #FF3632;
  border: 1px solid #C23031;
}
.container .leftMainCont .seat.selected {
  background-color: #D8BE02;
  border-color: rgba(0, 0, 0, 0.336);
}
.container .leftMainCont .seat.selected::after {
  background-color: #D8BE02;
  border-color: rgba(0, 0, 0, 0.336);
}
.container .leftMainCont .screen {
  height: 15px;
  width: 65%;
  background-color: #686868;
  position: absolute;
  top: 0;
  left: 50%;
  transform: translateX(-50%);
  display: flex;
  align-items: center;
  justify-content: center;
  border-radius: 0 0 8px 8px;
  max-width: 460px;
  user-select: none;
  margin: 0 auto;
}
.container .leftMainCont .screen small {
  color: #bdbdbd;
  font-size: 11px;
  letter-spacing: 0.3rem;
}
.container .mainSeatCont {
  background-color: #f1f1f1;
  height: 100%;
  padding: 3rem 1rem;
  position: relative;
  min-width: 100%;
  overflow-x: auto;
  margin: 0% auto;
}
.container .mainSeatCont .seatCont {
  display: flex;
  align-items: center;
  justify-content: center;
}
.container .mainSeatCont .seatCont .seatRowCont {
  display: flex;
}
.container .mainSeatCont .seatCont .seatRowCont2 {
  margin: 0 1.5rem;
}
.container .confirmCont {
  background-color: #f1f1f1;
  display: flex;
  flex-direction: column;
  padding: 2rem;
}
.container .confirmCont .rightTopCont {
  display: flex;
  flex-direction: column;
  justify-content: flex-start;
  align-items: flex-start;
  border-bottom: 1px solid #c4c4c4;
}
.container .confirmCont .movieInfo div {
  margin-bottom: 0.8rem;
}
.container .confirmCont .movieInfo p {
  color: #bdbdbd;
  text-transform: uppercase;
  letter-spacing: 1px;
  font-size: 12px;
  margin-bottom: 0.2rem;
}
.container .confirmCont .movieInfo .dateOn {
  color: #414141;
  font-size: 14px;
  margin-top: 0.4rem;
}
.container .confirmCont .movieInfo h1 {
  color: #414141;
  margin-top: 0.2rem;
}
.container .confirmCont .selectMovie select {
  padding: 0.375rem 0.75rem;
  border: 1px solid #c4c4c4;
  outline: none;
  border-radius: 3px;
  color: #686868;
  font-family: inherit;
  margin-top: 0.4rem;
  background-color: transparent;
}
.container .confirmCont .rightBottomCont .selectedSeatCont {
  border-bottom: 1px solid #c4c4c4;
  padding: 1rem 0;
}
.container .confirmCont .rightBottomCont .selectedSeatCont p {
  font-size: 12px;
  color: #bdbdbd;
}
.container .confirmCont .rightBottomCont .selectedSeatCont .selectedSeat {
  border: 3px solid #D8BE02;
  color: #D8BE02;
  padding: 0.375rem 1.8rem;
  border-radius: 3px;
  user-select: none;
  min-width: 77.3px;
  max-width: 77.3px;
  display: flex;
  align-items: center;
  justify-content: center;
  float: left;
}
.container .confirmCont .rightBottomCont .selectedSeatCont .selectedSeat:hover {
  background-color: rgba(144, 238, 144, 0.151);
  transition: 0.3s ease background-color;
}
.container .confirmCont .rightBottomCont .selectedSeatCont .selectedSeatsHolder {
  display: grid;
  grid-template-columns: repeat(auto-fit, minmax(67.3px, 67px));
  grid-column-gap: 1rem;
  grid-row-gap: 0.5rem;
  margin-top: 0.8rem;
  grid-auto-columns: auto;
  position: relative;
}
.container .confirmCont .rightBottomCont .numberOfSeatsCont {
  display: flex;
  justify-content: space-between;
  width: 100%;
  align-items: center;
  padding: 1.5rem 1rem;
  user-select: none;
}
.container .confirmCont .rightBottomCont .numberOfSeatsCont .numberOfSeat p {
  color: #414141;
  font-size: 13px;
}
.container .confirmCont .rightBottomCont .numberOfSeatsCont .priceCont {
  color: crimson;
}
.container .confirmCont .rightBottomCont .buttonCont {
  display: flex;
  justify-content: space-between;
  padding: 1rem;
}
.container .confirmCont .rightBottomCont .buttonCont button {
  padding: 0.75rem 2rem;
  cursor: pointer;
  border: none;
  outline: none;
  background-color: transparent;
  color: #000000;
  border-radius: 4px;
}
.container .confirmCont .rightBottomCont .buttonCont .cancelBtn button {
  background-color: #D8BE02;
  box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
  border: 3px solid #000000;
}
.container .confirmCont .rightBottomCont .buttonCont .cancelBtn button:hover {
  background-color: rgb(204, 0, 41);
  transition: 0.3s ease background-color;
}
.container .confirmCont .rightBottomCont .buttonCont .proceedBtnEl button {
  background-color: #D8BE02;
  box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
  transition: 0.3s ease background-color;
  border: 3px solid #000000;
}
.container .confirmCont .rightBottomCont .buttonCont .proceedBtnEl button:hover {
  background-color: rgba(84, 216, 84, 0.808);
}
.container .rightBottomCont .noSelected {
  text-align: center;
  color: crimson;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  font-size: 12px;
  color: #bdbdbd;
  text-transform: uppercase;
  width: 200px;
}

body.modal-active {
  overflow: hidden;
  padding-right: 17px;
}
body.modal-active .overlay {
  display: block;
}

.overlay {
  position: fixed;
  height: 100vh;
  width: 100%;
  background-color: #000;
  top: 0%;
  left: 0%;
  opacity: 0.3;
  display: none;
}

.successModal {
  width: 80%;
  max-width: 450px;
  background-color: #fff;
  position: fixed;
  top: 50%;
  display: flex;
  align-items: center;
  justify-content: center;
  flex-direction: column;
  border-radius: 0.4rem;
  box-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;
  padding: 1rem;
  left: 50%;
  transform: translate(-50%, -50%);
  text-align: center;
  background-image: url(https://github.com/Dinesh1042/Vanilla-JavaScript-Projects/blob/main/Movie%20Booking/asset/c1.png?raw=true);
  background-size: 140%;
  background-position: top center;
  user-select: none;
  z-index: 11;
  animation: 1s ease modalAnimation;
}
.successModal .modalTop {
  padding: 1rem;
}
.successModal .modalTop img {
  width: 100px;
}
.successModal .modalCenter {
  padding: 0.5rem 2.5rem;
}
.successModal .modalCenter h1 {
  color: #414141;
}
.successModal .modalCenter p {
  color: #686868;
  margin-top: 0.5rem;
}
.successModal .modalBottom {
  margin-top: 1rem;
}
.successModal .modalBottom button {
  background-color: lightgreen;
  border: none;
  outline: none;
  padding: 0.75rem 1.3rem;
  border-radius: 0.2rem;
  cursor: pointer;
  color: #fff;
  box-shadow: rgba(0, 0, 0, 0.16) 0px 1px 4px;
  transition: 0.3s ease background-color;
}
.successModal .modalBottom button:hover {
  background-color: rgba(84, 216, 84, 0.808);
}

@media (min-width: 800px) {
  .container {
    display: flex;
  }
  .container .confirmCont {
    min-width: 300px;
    max-width: 300px;
    float: right;
    padding: 2rem;
    min-height: 100vh;
  }
  .container .confirmCont .rightBottomCont .buttonCont {
    flex-direction: column-reverse;
  }
  .container .confirmCont .rightBottomCont .buttonCont button {
    width: 100%;
    padding: 0.8rem 0.75rem;
    margin-bottom: 0.8rem;
  }
  .container .legendContainer {
    justify-content: start;
    align-items: flex-start;
  }
  .container .legendContainer ul {
    margin: unset;
  }
}
@media (max-width: 430px) {
  .container .mainSeatCont {
    padding-left: 0;
  }
  .container .mainSeatCont .seatCont {
    display: flex;
    min-width: 500px;
    align-items: center;
  }
  .container .mainSeatCont .screen {
    min-width: 400px;
    transform: translateX(-30%);
  }
  .successModal .modalCenter {
    padding: 0.4rem;
  }
  .successModal .modalCenter h1 {
    font-size: 17px;
  }
  .successModal .modalCenter p {
    margin-top: 0.3rem;
  }
  body.modal-active {
    padding-right: 0px;
  }
}

/*# sourceMappingURL=reserva.css.map */
.heading {
    text-align: center;
    color: #000000;
    text-transform: uppercase;
    padding-bottom: 3.5rem;
    font-size: 4rem;
}

.heading span {
    color: #F0D303;
    text-transform: uppercase;
}
.btn {
  margin-top: 1rem;
  display: inline-block;
  padding: 0.9rem 3rem;
  font-size: 1.7rem;
  color: var(--black);
  background: #D8BE02;
  cursor: pointer;
  border: 3px solid #000000;
}
.btn:hover {
  box-shadow: 0 12px 16px 0 rgba(0, 0, 0, 0.24), 0 17px 50px 0 rgba(0, 0, 0, 0.19);
}
</style>
  