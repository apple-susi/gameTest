using UnityEngine;
using UnityEngine.UIElements;

public class LifeCycle : MonoBehaviour
{
    /*
    // 초기화 영역 Start
    void Awake()
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    // 활성화 영역 Start
    void OnEnable()
    {
        Debug.Log("플레이이어가 로그인했습니다.");
    }
    // 활성화 영역 End

    void Start()
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    // 초기화 영역 End

    // 물리연산 영역 Start  // cpu에 따라 주기적으로 됨
    void FixedUpdate()
    {
        Debug.Log("이동~");
    }
    // 물리연산 영역 End

    // 게임로직 영역 Start // 물리연산 보다 떨어지는 주기로 
    void Update()
    {
        Debug.Log("몬스터 사냥!!");
    }
    // 게임로직 영역 End

    // 물리연산, 게임로직 연산 등이 끝난 후 후처리 영역 Start
    void LateUpdate()
    {
        Debug.Log("경험치 획득.");    
    }
    // 물리연산, 게임로직 연산 등이 끝난 후 후처리 영역 End

    // 비활성화 영역 Start
    void OnDisable()
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }
    // 비활성화 영역 End

    // 해체 영역 Start
    void OnDestroy()
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");    
    }
    // 해체 영역 Start
    */

    /*void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        // 키보드 입력시 행동 제어 Start
        if (Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        // 키보드 입력시 행동 제어 End

        // 마우스 입력시 행동 제어 Start
        // 0 = 좌클릭, 1 = 우클릭
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");
        // 마우스 입력시 행동 제어 End

        // Edit -> Project Settings -> InputManager 항목의 버튼 값으로 제어 Start
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        // Edit -> Project Settings -> InputManager 항목의 버튼 값으로 제어 End


        if (Input.GetButton("Horizontal")){
            Debug.Log("횡 이동 중..."
                //+ Input.GetAxis("Horizontal")); // 입력 시간에 따른 가중치 표현 가능
                + Input.GetAxisRaw("Horizontal")); // 입력 시간 가중치 X
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..."
                //+ Input.GetAxis("Vertical")); // 입력 시간에 따른 가중치 표현 가능
                + Input.GetAxisRaw("Vertical")); // 입력 시간 가중치 X
        }
    }*/

    /*void Update()
    {
         Vector3 vec = new Vector3(
             Input.GetAxisRaw("Horizontal"),
             Input.GetAxisRaw("Vertical"),
             0);
        transform.Translate(vec); // Vector = 방향과 그에 대한 크기 값 (뒤에 붙는 숫자에 따라 차원이라고 생각하면 편함)   
    }*/

    /*Vector3 tartget = new Vector3(8, 1.5f, 0);

    void Update()
    {
        // MoveTowards(현재위치, 목표위치, 속도) = 등속 이동
        transform.position =
            Vector3.MoveTowards(transform.position, tartget, 1f);

        // SmoothDamp(현재위치, 목표위치, 참조 속도, 속도)
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, tartget, ref velo, 0.1f);

        // Lerp() = 선형 보간, SmoothDamp 보다 감속시간이 김
        transform.position =
            Vector3.Lerp(transform.position, tartget, 0.1f);

        //Slerp() = 구면 선형 보간, 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, tartget, 0.05f);

        // Time.deltaTime = 컴퓨터 성능에따른 응답 속도를 맞춰줌
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") * Time.deltaTime,
            Input.GetAxisRaw("Vertical") * Time.deltaTime, 0);
        transform.Translate(vec);
    }*/

}
